using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;


namespace EX_EditorBase 
{
    public partial class EX_EDITORBASE: Form
    {
        StreamReader leitura = null;
        public EX_EDITORBASE()
        {
            InitializeComponent();
        }

        
        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Eventos Novo
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        // Criar Função Novo()
        private void Novo()
        {
            rtb_Texto.Clear(); // Método "Clear" limpa a área de edição do objeto
            rtb_Texto.Focus(); // Método "Focus" posiciona o cursor na área de edição do Objeto
        }

        // Eventos Abrir
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        //Criar a Função Abrir
        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\User
            \Documents\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "*.TXT|*.txt|Todos Arquivos (*.*)| *.* ";

        try
            {
                if (this.openFileDialog1.ShowDialog() ==
                DialogResult.OK)
                {
                    FileStream arquivo = new FileStream
                    (openFileDialog1.FileName, FileMode.Open,
                    FileAccess.Read);
                    StreamReader sr = new StreamReader(arquivo);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.rtb_Texto.Text = "";
                    string linha = sr.ReadLine();
                    while (linha != null)
                    {
                        this.rtb_Texto.Text += linha + "\n";
                        linha = sr.ReadLine();
                    }
                    sr.Close();
                }
            }

        catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir : " + ex.Message,
                "Sistema Informa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        // Criar Função Salvar
        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() ==
                DialogResult.OK)
                {
                    FileStream arquivo = new FileStream
                    (saveFileDialog1.FileName, FileMode.OpenOrCreate,
                    FileAccess.Write);
                    StreamWriter sw = new StreamWriter(arquivo);
                    sw.Flush();
                    sw.BaseStream.Seek(0, SeekOrigin.Begin);
                    sw.Write(this.rtb_Texto.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar : " +
                ex.Message, "Sistema Informa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        // Eventos Copiar
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        // Criar a Função Copiar
        private void Copiar()
        {
            if (rtb_Texto.SelectionLength > 0)
            {
                rtb_Texto.Copy();
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        //Criar a Função Colar
        private void Colar()
        {
            rtb_Texto.Paste();
        }

        // Eventos Negrito
        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        // Criar a Função Negrito
        private void Negrito()
        {
            string nomeFonte = rtb_Texto.SelectionFont.Name;
            float tamanhoFonte = rtb_Texto.SelectionFont.Size;
            bool resp;
            resp = rtb_Texto.SelectionFont.Bold;
            //MessageBox.Show("" + resp);
            if (resp == false)
            {
                rtb_Texto.SelectionFont = new Font(nomeFonte,
                tamanhoFonte, FontStyle.Bold);
            }
            else
            {
                rtb_Texto.SelectionFont = new Font(nomeFonte,
                tamanhoFonte, FontStyle.Regular);
            }
        }

        // Eventos Italico
        private void btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        //Criar a Função Italico
        private void Italico()
        {
            string nomeFonte = rtb_Texto.SelectionFont.Name;
            float tamanhoFonte = rtb_Texto.SelectionFont.Size;
            bool resp;
            resp = rtb_Texto.SelectionFont.Italic;
            //MessageBox.Show("" + resp);
            if (resp == false)
            {
                rtb_Texto.SelectionFont = new Font(nomeFonte,
                tamanhoFonte, FontStyle.Italic);
            }
            else
            {
                rtb_Texto.SelectionFont = new Font(nomeFonte,
                tamanhoFonte, FontStyle.Regular);
            }
        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Eventos Sublinhar
        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhar();
        }

        private void btn_Sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhar();
        }

        //Criar a Função Sublinhar
        private void Sublinhar()
        {
            string nomeFonte = rtb_Texto.SelectionFont.Name;
            float tamanhoFonte = rtb_Texto.SelectionFont.Size;
            bool resp;
            resp = rtb_Texto.SelectionFont.Underline;
            //MessageBox.Show(""+resp);
            if (resp == false)
            {
                rtb_Texto.SelectionFont = new Font(nomeFonte,
                tamanhoFonte, FontStyle.Underline);
            }
            else
            {
                rtb_Texto.SelectionFont = new Font(nomeFonte,
                tamanhoFonte, FontStyle.Regular);
            }
        }
        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            if (fonte.ShowDialog() == DialogResult.OK)
            {
                rtb_Texto.Font = fonte.Font;
            }
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            Esquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Esquerda();
        }

        //Criar a Função Esquerda
        private void Esquerda()
        {
            rtb_Texto.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Eventos Centralizar
        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void btn_Centro_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        //Criar a Função Centralizar
        private void Centralizar()
        {
            rtb_Texto.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Eventos Direita

        private void btn_Direita_Click(object sender, EventArgs e)
        {
            Direita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Direita();
        }

        //Criar a Função Direita
        private void Direita()
        {
            rtb_Texto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            //Iremos Concluir este evento posteriormente... Gerar PDF
            try
                {
                    printDialog1.Document = printDocument1;
                    string strTexto = this.rtb_Texto.Text;
                    StringReader ler = new StringReader(strTexto);
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                    printDocument1.Print();
                    }
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
            printDocument1.Print();
            }
            }
            */

            // Visualizar Impressão
            try
            {
                string strTexto = this.rtb_Texto.Text;
                StringReader ler = new StringReader(strTexto);
                //PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var ppd = printPreviewDialog1;
                ppd.Document = printDocument1;
                ppd.Text = "CCS - Visualizando a impressão";
                ppd.WindowState = FormWindowState.Maximized;
                ppd.PrintPreviewControl.Zoom = 1;
                ppd.FormBorderStyle = FormBorderStyle.Fixed3D;
                ppd.ShowDialog();
            }

            catch (Exception erroP)
            {
                MessageBox.Show("Erro de Impressão:" + erroP.Message);
            }
        }

        //Criar esta Processo, e selecionar o Objeto "printDocumnto1", após, em sua propriedades
        //Selecionar Eventos "PrintPage" e selecionar "printDocumento1_PrintPage", GRavar e Executar...
            private void printDoccumento1_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
            {
            float linhasPorPagina = 0;
            float Posicao_Y = 0;
            int contador = 0;
            StringReader ler = new StringReader(rtb_Texto.Text);
            //defina as margens e o valor minimo
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;
            if (MargemEsquerda < 5)
                MargemEsquerda = 20;
            if (MargemSuperior < 5)
                MargemSuperior = 20;
            //define a fonte
            string linha = null;
            Font FonteDeImpressao = this.rtb_Texto.Font;
            SolidBrush meupincel = new SolidBrush(Color.Black);
            //StreamReader leitor = null;
            //Calcula o numero de linhas por página usando as medidas das margens
            linhasPorPagina = e.MarginBounds.Height /
            FonteDeImpressao.GetHeight(e.Graphics);
            // Vamos imprimir cada linha implementando um StringReader
            linha = ler.ReadLine();

            while (contador < linhasPorPagina)
            {
                // calcula a posicao da proxima linha baseado na altura da fonte de acordo com o dispositivo de impressão
                Posicao_Y = (MargemSuperior + (contador *
                FonteDeImpressao.GetHeight(e.Graphics)));
                // desenha a proxima linha no controle richtextbox
                e.Graphics.DrawString(linha, FonteDeImpressao, meupincel, MargemEsquerda, Posicao_Y, new StringFormat());
                //conta a linha e incrementa uma unidade
                contador += 1;
                linha = ler.ReadLine();
            }

            // se existir mais linhas imprime outra página
            if ((linha != null))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            meupincel.Dispose();
        }
        //Fim do Código...


        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Texto.Undo();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_Texto.Redo();
        }


    }
}
