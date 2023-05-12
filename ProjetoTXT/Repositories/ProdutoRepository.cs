using ProjetoTXT.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjetoTXT.Repositories
{
    public class ProdutoRepository
    {
        public void GravarArquivo(Produto produto)
        {
            var path = "c:\\temp\\";
            CriarDiretorio(path);

            using (var streamWriter = new StreamWriter(path + "produtos_.txt", true))
            {
                streamWriter.WriteLine("Código............: " + produto.Codigo);
                streamWriter.WriteLine("Nome..............: " + produto.Nome);
                streamWriter.WriteLine("Preço.............: " + produto.Preco);
                streamWriter.WriteLine("Quantidade........: " + produto.Quantidade);
            }
        }
        public void CriarDiretorio(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
