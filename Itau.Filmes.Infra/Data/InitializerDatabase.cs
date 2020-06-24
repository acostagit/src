using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Itau.Filmes.Domain.Entities;
using Itau.Filmes.Domain.Interfaces.Services;

namespace Itau.Filmes.Infra.Data
{
    public static class InitializerDatabase
    {
        public static void Initializer(JuridicoContexto contexto)
        {
            if (contexto.Clientes.Any())
                return;

            var enderecos = new Endereco[]
            {
                new Endereco
                {
                    Logradouro="Rua Brasil, 755",
                    Bairro="Belo Horizonte",
                    CEP="083050000"

                }
            };
            contexto.AddRange(enderecos);

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    CodCliente=100,
                    CPF="12345678914",
                    dsCliente="Maria Torres",
                    Endereco =enderecos[0],
                    Email="maria@teste.com.br",
                },
                new Cliente
                {
                    CodCliente=200,
                    CPF="12345678915",
                    dsCliente="Luzia Silva",
                    Endereco =enderecos[0],
                    Email="luzia@teste.com.br",
                }
            };
            contexto.AddRange(clientes);

            var generos = new Genero[]
                    {
                new Genero
                {
                    dsGenero="Aventura"
                },
                new Genero
                {
                   dsGenero="Ação"
                }
             };
            contexto.AddRange(generos);

            var filmes = new Filme[]
             {
                new Filme
                {
                    CodFilme=500,
                    dsFilme="E o vento levou",
                    Dublado=true,
                    Genero = generos[0]
                },
                new Filme
                {
                    CodFilme=200,
                    dsFilme="Rambo III",
                    Dublado=true,
                    Genero = generos[1]
                },
                new Filme
                {
                    CodFilme=300,
                    dsFilme="Matrix Revolution",
                    Dublado=false,
                    Genero = generos[0]
                }
             };
            contexto.AddRange(filmes);

            contexto.SaveChanges();
        }
    }
}
