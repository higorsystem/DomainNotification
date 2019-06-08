using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotification.Prompt
{
    using DomainNotification.Application.Services;
    using DomainNotification.Prompt.DTO;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome: ");
            var nome = Console.ReadLine();
            Console.Write("\nEntre com e-amil: ");
            var email = Console.ReadLine();

            var pessoaDto = new PessoaDTO(Guid.NewGuid(), nome, email);
            var pessoaService = new PessoaService(pessoaDto.PessoaId, pessoaDto.Nome, pessoaDto.Email);

            Enviar(pessoaService, pessoaDto);
            Console.ReadKey();
        }

        public static void Enviar(PessoaService pessoaService, PessoaDTO pessoaDto)
        {
            pessoaService.SavePessoa(pessoaDto.PessoaId, pessoaDto.Nome);
            if (pessoaService.HasNotifications)
            {
                MostrarNotificacao(pessoaService);
            }
        }

        public static void MostrarNotificacao(Service pessoaService)
        {
            if (!pessoaService.HasNotifications)
            {
                return;
            }

            if (pessoaService.HasErrors)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nErrors\n");

                foreach (var error in pessoaService.Errors())
                {
                    Console.WriteLine(error.ToString());
                }
            }

            if (pessoaService.HasWarnings)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAlertas\n");

                foreach (var alerta in pessoaService.Warnings())
                {
                    Console.WriteLine(alerta.ToString());
                }
            }

            if (pessoaService.HasInformations)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nInformações\n");

                foreach (var informacao in pessoaService.Information())
                {
                    Console.WriteLine(informacao.ToString());
                }
            }
        }
    }
}
