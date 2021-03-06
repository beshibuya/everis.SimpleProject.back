﻿
using everis.SimpleProject.Application.Services;
using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Service;
using everis.SimpleProject.Domain.Services;
using Microsoft.Extensions.DependencyInjection;


namespace everis.SimpleProject.API.Config
{
    public static class ServicesConfig
    {
        public static void Configure(this IServiceCollection services)
        {
            services.AddTransient<IGenericService<Sigla>, SiglaAppSvcGeneric>();
            services.AddTransient<IAcessoSiglaService, AcessoSiglaAppSvcGeneric>();
            services.AddTransient<IGenericService<AcessoSigla>, AcessoSiglaAppSvcGeneric>();
            services.AddTransient<IGenericService<Anexo>, AnexoAppSvcGeneric>();
            services.AddTransient<IGenericService<SolicitacaoMudanca>, SolicitacaoMudancaAppSvcGeneric>();
            services.AddTransient<ISolicitacaoMudancaService, SolicitacaoMudancaAppSvcGeneric>();
            services.AddTransient<IGenericService<Colaborador>, ColaboradorAppSvcGeneric>();
            services.AddTransient<IColaboradorService, ColaboradorAppSvcGeneric>();
            services.AddTransient<IGenericService<Empresa>, EmpresaAppSvcGeneric>();
            services.AddTransient<IGenericService<Fase>, FaseAppSvcGeneric>();
            services.AddTransient<IFaseService, FaseAppSvcGeneric>();
            services.AddTransient<IGenericService<Pessoa>, PessoaAppSvcGeneric>();
            services.AddTransient<IPessoaService, PessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<Projeto>, ProjetoAppSvcGeneric>();
            services.AddTransient<IGenericService<ProjetoPessoa>, ProjetoPessoaAppSvcGeneric>();
            services.AddTransient<IProjetoPessoaService, ProjetoPessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<ProjetoTecnologia>, ProjetoTecnologiaAppSvcGeneric>();
            services.AddTransient<IProjetoTecnologiaService, ProjetoTecnologiaAppSvcGeneric>();
            services.AddTransient<ITelefoneService, TelefoneAppSvcGeneric>();
            services.AddTransient<IGenericService<Telefone>, TelefoneAppSvcGeneric>();
            services.AddTransient<IProjetoService, ProjetoAppSvcGeneric>();
            services.AddTransient<ILoginService, LoginAppSvcGeneric>();
            services.AddTransient<IGenericService<Anexo>, AnexoAppSvcGeneric>();
            services.AddTransient<IGenericService<Pessoa>, PessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<Superintendencia>, SuperintendenciaAppSvcGeneric>();
            services.AddTransient<IGenericService<Tecnologia>, TecnologiaAppSvcGeneric>();
            services.AddTransient<IGenericService<Status>, StatusAppSvcGeneric>();
            services.AddTransient<IGenericService<Ferramenta>, FerramentaAppSvcGeneric>();
            services.AddTransient<IGenericService<PoloAcesso>, PoloAcessoAppSvcGeneric>();
            services.AddTransient<IGenericService<AreaContratante>, AreaContratanteAppSvcGeneric>();
            services.AddTransient<IGenericService<DiretoriaContratante>, DiretoriaContratanteAppSvcGeneric>();
            services.AddTransient<IGenericService<TipoServico>, TipoServicoAppSvcGeneric>();
            services.AddTransient<IGenericService<Funcao>, FuncaoAppSvcGeneric>();
            services.AddTransient<IGenericService<Perfil>, PerfilAppSvcGeneric>();
            services.AddTransient<IGenericService<TipoPessoa>, TipoPessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<TipoTelefone>, TipoTelefoneAppSvcGeneric>();
            services.AddTransient<IGenericService<AcessoFerramenta>, AcessoFerramentaAppSvcGeneric>();
            services.AddTransient<IAcessoFerramentaService, AcessoFerramentaAppSvcGeneric>();
            services.AddTransient<IGenericService<ProjetoPessoaAtribuicao>, ProjetoPessoaAtribuicaoAppSvcGeneric>();
            services.AddTransient<IGenericService<Comunidade>, ComunidadeAppSvcGeneric>();
            services.AddTransient<IGenericService<Squad>, SquadAppSvcGeneric>();
            services.AddTransient<IGenericService<SquadPessoa>, SquadPessoaAppSvcGeneric>();
            services.AddTransient<IGenericService<TipoFase>, TipoFaseAppSvcGeneric>();
            services.AddTransient<IGenericService<ProjetoSquad>, ProjetoSquadAppSvcGeneric>();
            services.AddTransient<IProjetoSquadService, ProjetoSquadAppSvcGeneric>();
            services.AddTransient<GenericService<TipoDemanda>, TipoDemandaService>();
            services.AddTransient<ITipoDemandaService, TipoDemandaService>();
            services.AddTransient<IGenericService<Exts>, ExtsService>();
            services.AddTransient<IGenericService<ProjetoSigla>, ProjetoSiglaService>();
            services.AddTransient<IProjetoSiglaService, ProjetoSiglaService>();

        }
    }
}
