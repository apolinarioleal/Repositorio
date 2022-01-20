using Dominio.Entidades;
using Dominio.Interfaces;
using Dominio.InterfaceServico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ApiProduto : Controller
    {
        private readonly IProduto _Produto;
        private readonly IProdutoServico _IProdutoService;
        public ApiProduto(IProduto IProduto, IProdutoServico IProdutoServico)
        {
            _Produto = IProduto;
            _IProdutoService = IProdutoServico;
        }

        [HttpPost("/api/AdicionarComValidacao")]
        public async Task<List<Notifica>> AdicionarComValidacao(Produto Produto)
        {
            await _IProdutoService.AdicionarComValidacao(Produto);
            return Produto.Notificacoes;
        }



        [HttpPost("/api/Atualizar")]
        public async Task<List<Notifica>> Atualizar(Produto Produto)
        {
            await _Produto.Atualizar(Produto);
            return Produto.Notificacoes;
        }


        [HttpPost("/api/Excluir")]
        public async Task<List<Notifica>> Excluir(Produto Produto)
        {
            await _Produto.Excluir(Produto);
            return Produto.Notificacoes;
        }


        [HttpPost("/api/BuscarPorCodigo")]
        public async Task<Produto> BuscarPorCodigo(int codigo)
        {
            return await _Produto.BuscarPorCodigo(codigo);
        }



        [HttpPost("/api/ListarProdutosPorNome")]
        public async Task<List<Produto>> ListarProdutosPorNome(string nome)
        {
            return await _IProdutoService.ListarProdutosPorNome(nome);
        }


        [HttpPost("/api/ListarTudo")]
        public async Task<List<Produto>> ListarTudo()
        {
            return await _Produto.ListarTudo();
        }



    }
}
