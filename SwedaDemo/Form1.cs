using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace SwedaDemo { 
    public partial class frmPrincipal : Form {

        #region Status da Impressora
        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_eBuscarPortaVelocidade();

        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_fecharPorta();
        #endregion

        #region Configurações
        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_regPortaComunicacao(StringBuilder porta);
        #endregion

        #region Gaveta
        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_regModoGaveta(string status);

        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_iAcionarGaveta();
        #endregion

        #region Impressão de Texto
        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_iImprimirTexto(string texto, int tamanho);

        [DllImport("SI300.DLL", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SI300_iImprimirXML(string pszPath, string ptAutorizacao, string dhRecto, int tpCupom, string CIDTOKEN, string CSC, int viaEstabelecimento, bool Endereco);
        #endregion

        private int iRet, count = 0;
        private Timer timer = new Timer();
        private Timer timerConnect = new Timer();

        #region AnalisaRetorno
        public static void AnalisaRetorno(int retorno) {
            if (retorno == 1) {
                MessageBox.Show("Comando OK", "Resposta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (retorno == -99) {
                MessageBox.Show("Parâmetro Inválido", "Resposta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (retorno == 0) {
                MessageBox.Show("Erro: Sem comunicação com a Impressora", "Resposta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region AnalisaErro
        public static void AnalisaErro(int ret) {
            if (ret == -99) {
                MessageBox.Show("Parâmetro Inválido", "Resposta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ret == 0) {
                MessageBox.Show("Erro: Sem comunicação com a Impressora", "Resposta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ret == -8) {
                MessageBox.Show("Erro: Não foi possível localizar a Imagem !", "Resposta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public frmPrincipal() {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e) {
            imgLogo.Parent = imgBgTop;
            imgClosed.Parent = imgBgTop;
            //imgConnect.Parent = imgBgBot;
            //btnGaveta.Parent = imgBgBot;
            //btnImprimir.Parent = imgBgBot;
            timerConnect.Tick += new EventHandler(onTimerConnect);
            timerConnect.Interval = 3600000;
            timerConnect.Enabled = true;
            chkConnectStatus();
            txtCodeBar.Focus();
        }

        private void onTimerConnect(object sender, EventArgs e) {
            chkConnectStatus();
        }

        private void txtCodeBar_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                SI300_iImprimirXML("CFe.xml", null, null, 0, "000000", "111A1JH1-2222-3333-4444-5555WQQ55556", 2, false);
                // txtCodeBar.Text = "ENTER";
                imgCupom.Visible = false;
                imgCodeBar.Visible = true;

                timer.Tick += new EventHandler(onTimerCodeBar);
                timer.Interval = 2000;
                timer.Enabled = true;
            }
        }

        private void onTimerCodeBar(Object sender, EventArgs e) {
            switch (count) {
                case 0:
                   break;
                case 1:
                    imgCodeBar.Visible = false;
                    txtCodeBar.Text = "";
                    txtCodeBar.Focus();
                    break;
                default:
                    count = -1;
                    timer.Enabled = false;
                    break;
            }
            ++count;
        }

        private void imgConnect_Click(object sender, EventArgs e) {
            chkConnectStatus();
            txtCodeBar.Focus();
        }

        private void btnGaveta_Click(object sender, EventArgs e) {
            iRet = SI300_iAcionarGaveta();
            AnalisaRetorno(iRet);
            txtCodeBar.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e) {
            SI300_iImprimirXML("CFe.xml", null, null, 0, "000000", "111A1JH1-2222-3333-4444-5555WQQ55556", 2, false);
            txtCodeBar.Text = "Cupom Impresso";
            imgCodeBar.Visible = false;
            imgCupom.Visible = true;
            timer.Tick += new EventHandler(onTimerCupom);
            timer.Interval = 2000;
            timer.Enabled = true;
        }

        private void onTimerCupom(Object sender, EventArgs e) {
            switch (count) {
                case 0:
                    break;
                case 1:
                    imgCupom.Visible = false;
                    txtCodeBar.Text = "";
                    txtCodeBar.Focus();
                    break;
                default:
                    count = -1;
                    timer.Enabled = false;
                    break;
            }
            ++count;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            timerConnect.Enabled = false;
            timer.Enabled = false;
        }

        private void imgClosed_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void imgClosed_MouseHover(object sender, EventArgs e) {
            imgClosed.Image = Properties.Resources.btn_closed_over;
        }

        private void imgClosed_MouseLeave(object sender, EventArgs e)  {
            imgClosed.Image = Properties.Resources.btn_closed;
        }

        private void chkConnectStatus()  {
            iRet = SI300_eBuscarPortaVelocidade();
            if (iRet == 1)
                imgConnect.Image = Properties.Resources.connected;
            else if (iRet == 0)
                imgConnect.Image = Properties.Resources.disconnected;
        }
    }
}
