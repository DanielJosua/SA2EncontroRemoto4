using System;

namespace EncontroRemoto
{
   class Program
   {
       static void Main(string[] args)
       {

        //    Endereco end = new Endereco();

        //    end.logradouro = "Rua Albino Moraes";
        //    end.numero = 150;
        //    end.complemento = "Frente à loja de ferrugem";
        //    end.enderecoComercial = false;

        //     PessoaFisica novapf = new PessoaFisica();

        //     novapf.endereco = end;
        //     novapf.cpf = "123456789";
        //     novapf.dataNascimento = new DateTime(1996, 01, 18);
        //     novapf.nome = "Daniel Josua";

        //     PessoaFisica pf = new PessoaFisica();
        //     pf.ValidarDataNascimento(pf.dataNascimento);

        //     bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
        //     Console.WriteLine(idadeValida);

        //     if (idadeValida == true)
        //     {
        //         Console.WriteLine($"Cadastro Aprovado");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Cadastro Não Aprovado");
        //     }

            //Console.WriteLine(pf.ValidarDataNascimento(novapf.dataNascimento));
            //Console.WriteLine("Rua: " + novapf.endereco.logradouro + ", " + novapf.endereco.numero);

            PessoaJuridica pj = new PessoaJuridica();

            PessoaJuridica novapj = new PessoaJuridica();

            Endereco end = new Endereco();

            end.logradouro = "Rua X";
            end.numero = 129;
            end.complemento = "Próximo ao senai";
            end.enderecoComercial = true;

            novapj.endereco = end;
            novapj.cnpj = "1234567890001";
            novapj.razaoSocial = "Pessoa Juridica";

            if (pj.ValidarCNPJ(novapj.cnpj))
            {
                Console.WriteLine("CNpj Válido");
            }else{
                Console.WriteLine("CNPJ Invalido");
            }
       }
   }
}