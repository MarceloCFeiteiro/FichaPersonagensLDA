using System.IO;
using Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static iTextSharp.text.Font;

namespace Utils
{
    public static class HelpArquivoPdf
    {
        static readonly string dir = "C:";
        static readonly string nomeDaPasta = @"\Fichas de Personagens\";

        public static void ImprimirFichaPdf(Character personagem)
        {
            DirectoryInfo di = Directory.CreateDirectory(dir + nomeDaPasta);

            var doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            string caminho = di + $"Ficha{personagem.Name}.pdf";

            var pdfWiter = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            var pdfTable = new PdfPTable(3);

            pdfTable.AddCell("Nome: " + personagem.Name);
            pdfTable.AddCell("Nível : " + "10");
            pdfTable.AddCell("Exp : " + "67");

            pdfTable.AddCell("Raça: " + "Elfo");
            pdfTable.AddCell("Elemento : " + "Fogo");
            pdfTable.AddCell("Constituição : " + "10");

            pdfTable.AddCell("Classe: " + "Guerreiro");
            pdfTable.AddCell("Vel. Conjuração : " + "10");
            pdfTable.AddCell("Pode Aura : " + "4");
            doc.Add(pdfTable);

            doc.Close();
        }

        private static Image InserirImagem(string caminhoImagem, float largura, float altura)
        {
            var img = Image.GetInstance(caminhoImagem);
            img.ScaleAbsolute(largura, altura);

            return img;
        }

        private static Paragraph CriarParagrafo(string conteudo, FontFamily fonte, float size)
        {
            var paragrafo = new Paragraph(conteudo, new Font(fonte, size));

            return paragrafo;
        }

        private static Paragraph CabecalhoPrincipal(string conteudo, FontFamily fonte, float size, int alinhamento, string texto)
        {
            var titulo = new Paragraph();
            titulo.Font = new Font(fonte, size);
            titulo.Alignment = alinhamento;
            titulo.Add(texto);

            return titulo;
        }
    }
}
