# everis.SimpleProject.back
estrutura básica projeto .netCore DDD

Para incluir um item, seguir a ordem

1 - Adicionar a entidade everis.SimpleProject.Domain\Models (Ex: EntidadeNova.cs)

2 - A entidade criada deve herdar de entity e fornecer uma implementação par ao método abstrato MergeFrom,
se não for passível de merge, o método deverá ter apenas um return;

public class EntidadeNova : Entity
{
    public override void MergeFrom(object other)
    {
        return;
    }
}

3 - Adicionar o AppService da entidade criada, em everis.SimpleProject.Application\Services (EntidadeNovaAppService.cs)

4 - O Service criado deve herdar de GenericService, e fornecer a entidade atribuída a esse service, além disso, deve fornecer 
  a) a implementação para o método abstrato "BuscarPor"
  b) a implementação do construtor que será utilizada na injeção de dependência
      public class EntidadeNovaAppService : GenericService<EntidadeNova>
      {
         public EntidadeNovaAppService(AppDbContext context) : base(context)
          {
              repository = new GenericRepository<EntidadeNova>(context);
          }
          public IEnumerable<EntidadeNova> BuscarPor(EntidadeNova filter){
            try
                  {
                      var result = repository.BuscarPor(b => b.Ativo);
                      return result;
                  }
                  catch (Exception ex)
                  {
                      throw ex;
                  }
          }
      }

5 - Incluir a informação de injeção de dependência em everis.SimpleProject.API\Config\ServicesConfig.cs

        public static void Configure(this IServiceCollection services)
        {
        ...
          services.AddTransient<IGenericService<EntidadeNova>, EntidadeNovaAppService>();
        ...
        }
        
6 - Criar uma nova classe em everis.SimpleProject.API\Controllers, não recomendado utilizar a função do Visual Studio de criar novo controller, pois gera "sujeira" (rotas default sem utilidade no projeto), assim sendo, a classe criada como controller deverá ser EntidadeNovaController.cs

7 - No controller criado, indicador que esta herda do controller base, e fornecer a entidade que será injetada.

using everis.SimpleProject.Domain.Models;
namespace everis.SimpleProject.API.Controllers
{
    public class EntidadeNovaController : BaseController<EntidadeNova>
    {
    }
}

