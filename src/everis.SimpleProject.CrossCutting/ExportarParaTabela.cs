using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace everis.SimpleProject.CrossCutting
{
    public static class ExportarParaTabela<T>
    {
        public static byte[] GerarArquivoExportar(IEnumerable<T> itensparaExportar, bool gerarCsv = true)
        {
            var dataTableExportar = ConverterParaDataTable(itensparaExportar.ToList());
            var cabecalho = GerarCabecalho(dataTableExportar.Columns, gerarCsv);
            var conteudo = GerarConteudo(dataTableExportar.Rows, typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance), gerarCsv);

            var sbResultado = new StringBuilder();

            sbResultado.AppendLine(cabecalho);
            sbResultado.AppendLine(conteudo);

            return Encoding.UTF8.GetBytes(gerarCsv ?
                sbResultado.ToString() :
                $"<table>{sbResultado.ToString()}</table>");
        }

        private static string GerarCabecalho(DataColumnCollection colunas, bool gerarCsv = true)
        {
            var sb = new StringBuilder();
            if (gerarCsv)
            {
                for (int i = 0; i < colunas.Count; i++)
                {
                    sb.Append($"\"{colunas[i].ColumnName}\"{(i != colunas.Count - 1 ? ";" : "")}");
                }
            }
            sb.AppendLine("<thead>\n<tr>");
            for (int i = 0; i < colunas.Count; i++)
            {
                sb.AppendLine($"<th style=\"border: 1px solid;\">{colunas[i].ColumnName}</th>");
            }
            sb.AppendLine("</tr>\n</thead>");
            return sb.ToString();
        }

        public static string GerarConteudo(DataRowCollection linhas, PropertyInfo[] propriedades, bool gerarCsv = true)
        {
            var sb = new StringBuilder();
            foreach (DataRow linha in linhas)
            {
                var conteudoLinha = new StringBuilder();
                for (var i = 0; i < linha.ItemArray.Length; i++)
                {
                    string conteudo;
                    var tipoPropriedade = propriedades[i].PropertyType;
                    switch (tipoPropriedade.Name)
                    {
                        case "Boolean":
                            conteudo = Convert.ToBoolean(linha.ItemArray[i]) ? "Verdadeiro" : "Falso";
                            break;
                        case "DateTime":
                            var data = DateTime.Parse(linha.ItemArray[i].ToString());
                            conteudo = data != null && data.Date > DateTime.MinValue ?
                            $"{ data.ToString("ddflVl / yyyy")} { data.ToString("hh:mm:ss")}" :
                                string.Empty;
                            break;
                        default:
                            conteudo = linha.ItemArray[i].ToString();
                            break;
                    }
                    if (gerarCsv)
                    {
                        conteudoLinha.Append($"\"{conteudo}\"{(i != linha.ItemArray.Length - 1 ? ";" : "")}");
                    }
                    else
                    {
                        conteudoLinha.Append($"<td style=\"border:1px colid;\">{conteudo}</td>");
                    }
                }
                sb.AppendLine($"{(!gerarCsv ? "<tr>\n" : "")}{conteudoLinha.ToString()}{(!gerarCsv ? "</tr>" : "")}");
            }

            return $"{(!gerarCsv ? "<tbody>\n" : "")}{sb.ToString()}{(!gerarCsv ? "</tbody>" : "")}";
        }

        public static DataTable ConverterParaDataTable(List<T> items)
        {
            var tipoDet = typeof(T);
            var dt = new DataTable(tipoDet.Name);
            var propriedades = tipoDet.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            propriedades.ToList().ForEach(f => dt.Columns.Add(f.Name));
            items.ForEach(item =>
            {
                var valores = new object[propriedades.Length];
                for (int i = 0; i < propriedades.Length; i++)
                {
                    valores[i] = propriedades[i].GetValue(item, null);
                }
                dt.Rows.Add(valores);
            });
            return dt;
        }

    }
}
