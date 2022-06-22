using System.Windows.Forms;

namespace SistemaLDA
{
    /// <summary>
    /// Patial Class que define o cabeçalho com as características do personagem
    /// </summary>
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button BtnSalvar;

        private GroupBox GBCaracteristcs;

        private Label LblNomePersonagem;
        private Label LblRacaPersonagem;
        private Label LblClassePersonagem;
        private Label LblNivel;
        private Label LblElemento;
        private Label LblVelConjuracao;
        private Label LblExp;
        private Label LblConstituicao;
        private Label LblPoderAura;

        private TextBox TxtNome;
        private TextBox TxtRaca;
        private TextBox TxtClasse;
        private TextBox TxtNivel;
        private TextBox TxtElemento;
        private TextBox TxtVelConjuracao;
        private TextBox TxtExp;
        private TextBox TxtConstituicao;
        private TextBox TxtPoderAura;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBCaracteristcs = new System.Windows.Forms.GroupBox();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.TxtConstituicao = new System.Windows.Forms.TextBox();
            this.TxtPoderAura = new System.Windows.Forms.TextBox();
            this.LblExp = new System.Windows.Forms.Label();
            this.LblConstituicao = new System.Windows.Forms.Label();
            this.LblPoderAura = new System.Windows.Forms.Label();
            this.TxtNivel = new System.Windows.Forms.TextBox();
            this.TxtElemento = new System.Windows.Forms.TextBox();
            this.TxtVelConjuracao = new System.Windows.Forms.TextBox();
            this.LblNivel = new System.Windows.Forms.Label();
            this.LblElemento = new System.Windows.Forms.Label();
            this.LblVelConjuracao = new System.Windows.Forms.Label();
            this.TxtRaca = new System.Windows.Forms.TextBox();
            this.TxtClasse = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblRacaPersonagem = new System.Windows.Forms.Label();
            this.LblClassePersonagem = new System.Windows.Forms.Label();
            this.LblNomePersonagem = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GBCaracteristcs.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCaracteristcs
            // 
            this.GBCaracteristcs.Controls.Add(this.TxtExp);
            this.GBCaracteristcs.Controls.Add(this.TxtConstituicao);
            this.GBCaracteristcs.Controls.Add(this.TxtPoderAura);
            this.GBCaracteristcs.Controls.Add(this.LblExp);
            this.GBCaracteristcs.Controls.Add(this.LblConstituicao);
            this.GBCaracteristcs.Controls.Add(this.LblPoderAura);
            this.GBCaracteristcs.Controls.Add(this.TxtNivel);
            this.GBCaracteristcs.Controls.Add(this.TxtElemento);
            this.GBCaracteristcs.Controls.Add(this.TxtVelConjuracao);
            this.GBCaracteristcs.Controls.Add(this.LblNivel);
            this.GBCaracteristcs.Controls.Add(this.LblElemento);
            this.GBCaracteristcs.Controls.Add(this.LblVelConjuracao);
            this.GBCaracteristcs.Controls.Add(this.TxtRaca);
            this.GBCaracteristcs.Controls.Add(this.TxtClasse);
            this.GBCaracteristcs.Controls.Add(this.TxtNome);
            this.GBCaracteristcs.Controls.Add(this.LblRacaPersonagem);
            this.GBCaracteristcs.Controls.Add(this.LblClassePersonagem);
            this.GBCaracteristcs.Controls.Add(this.LblNomePersonagem);
            this.GBCaracteristcs.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GBCaracteristcs.Location = new System.Drawing.Point(32, 20);
            this.GBCaracteristcs.Name = "GBCaracteristcs";
            this.GBCaracteristcs.Size = new System.Drawing.Size(939, 178);
            this.GBCaracteristcs.TabIndex = 0;
            this.GBCaracteristcs.TabStop = false;
            this.GBCaracteristcs.Text = "Caracteristicas";
            // 
            // TxtExp
            // 
            this.TxtExp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtExp.Location = new System.Drawing.Point(783, 85);
            this.TxtExp.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtExp.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.Size = new System.Drawing.Size(100, 30);
            this.TxtExp.TabIndex = 17;
            // 
            // TxtConstituicao
            // 
            this.TxtConstituicao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtConstituicao.Location = new System.Drawing.Point(783, 48);
            this.TxtConstituicao.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtConstituicao.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtConstituicao.Name = "TxtConstituicao";
            this.TxtConstituicao.Size = new System.Drawing.Size(100, 30);
            this.TxtConstituicao.TabIndex = 16;
            // 
            // TxtPoderAura
            // 
            this.TxtPoderAura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPoderAura.Location = new System.Drawing.Point(783, 119);
            this.TxtPoderAura.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtPoderAura.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtPoderAura.Name = "TxtPoderAura";
            this.TxtPoderAura.Size = new System.Drawing.Size(100, 30);
            this.TxtPoderAura.TabIndex = 15;
            // 
            // Exp
            // 
            this.LblExp.AutoSize = true;
            this.LblExp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExp.Location = new System.Drawing.Point(686, 48);
            this.LblExp.Name = "Exp";
            this.LblExp.Size = new System.Drawing.Size(34, 20);
            this.LblExp.TabIndex = 14;
            this.LblExp.Text = "EXP";
            // 
            // Constituicao
            // 
            this.LblConstituicao.AutoSize = true;
            this.LblConstituicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblConstituicao.Location = new System.Drawing.Point(686, 84);
            this.LblConstituicao.Name = "Constituicao";
            this.LblConstituicao.Size = new System.Drawing.Size(91, 20);
            this.LblConstituicao.TabIndex = 13;
            this.LblConstituicao.Text = "Constituicao";
            // 
            // PoderAura
            // 
            this.LblPoderAura.AutoSize = true;
            this.LblPoderAura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPoderAura.Location = new System.Drawing.Point(686, 119);
            this.LblPoderAura.Name = "PoderAura";
            this.LblPoderAura.Size = new System.Drawing.Size(82, 20);
            this.LblPoderAura.TabIndex = 12;
            this.LblPoderAura.Text = "Poder Aura";
            // 
            // TxtNivel
            // 
            this.TxtNivel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNivel.Location = new System.Drawing.Point(445, 84);
            this.TxtNivel.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtNivel.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtNivel.Name = "TxtNivel";
            this.TxtNivel.Size = new System.Drawing.Size(100, 30);
            this.TxtNivel.TabIndex = 11;
            // 
            // TxtElemento
            // 
            this.TxtElemento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtElemento.Location = new System.Drawing.Point(445, 119);
            this.TxtElemento.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtElemento.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtElemento.Name = "TxtElemento";
            this.TxtElemento.Size = new System.Drawing.Size(100, 30);
            this.TxtElemento.TabIndex = 10;
            // 
            // TxtVelConjuracao
            // 
            this.TxtVelConjuracao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtVelConjuracao.Location = new System.Drawing.Point(445, 48);
            this.TxtVelConjuracao.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtVelConjuracao.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtVelConjuracao.Name = "TxtVelConjuracao";
            this.TxtVelConjuracao.Size = new System.Drawing.Size(100, 30);
            this.TxtVelConjuracao.TabIndex = 9;
            // 
            // Nivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNivel.Location = new System.Drawing.Point(336, 119);
            this.LblNivel.Name = "Nivel";
            this.LblNivel.Size = new System.Drawing.Size(43, 20);
            this.LblNivel.TabIndex = 8;
            this.LblNivel.Text = "Nível";
            // 
            // Elemento
            // 
            this.LblElemento.AutoSize = true;
            this.LblElemento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblElemento.Location = new System.Drawing.Point(336, 84);
            this.LblElemento.Name = "Elemento";
            this.LblElemento.Size = new System.Drawing.Size(72, 20);
            this.LblElemento.TabIndex = 7;
            this.LblElemento.Text = "Elemento";
            // 
            // VelConjuracao
            // 
            this.LblVelConjuracao.AutoSize = true;
            this.LblVelConjuracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVelConjuracao.Location = new System.Drawing.Point(336, 48);
            this.LblVelConjuracao.Name = "VelConjuracao";
            this.LblVelConjuracao.Size = new System.Drawing.Size(111, 20);
            this.LblVelConjuracao.TabIndex = 6;
            this.LblVelConjuracao.Text = "Vel. Conjuração";
            // 
            // TxtRaca
            // 
            this.TxtRaca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtRaca.Location = new System.Drawing.Point(54, 84);
            this.TxtRaca.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtRaca.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtRaca.Name = "TxtRaca";
            this.TxtRaca.Size = new System.Drawing.Size(100, 30);
            this.TxtRaca.TabIndex = 5;
            // 
            // TxtClasse
            // 
            this.TxtClasse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtClasse.Location = new System.Drawing.Point(54, 125);
            this.TxtClasse.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtClasse.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtClasse.Name = "TxtClasse";
            this.TxtClasse.Size = new System.Drawing.Size(100, 30);
            this.TxtClasse.TabIndex = 4;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNome.Location = new System.Drawing.Point(54, 48);
            this.TxtNome.MaximumSize = new System.Drawing.Size(100, 20);
            this.TxtNome.MinimumSize = new System.Drawing.Size(100, 20);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 30);
            this.TxtNome.TabIndex = 3;
            // 
            // RacaPersonagem
            // 
            this.LblRacaPersonagem.AutoSize = true;
            this.LblRacaPersonagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRacaPersonagem.Location = new System.Drawing.Point(6, 124);
            this.LblRacaPersonagem.Name = "RacaPersonagem";
            this.LblRacaPersonagem.Size = new System.Drawing.Size(41, 20);
            this.LblRacaPersonagem.TabIndex = 2;
            this.LblRacaPersonagem.Text = "Raça";
            // 
            // ClassePersonagem
            // 
            this.LblClassePersonagem.AutoSize = true;
            this.LblClassePersonagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblClassePersonagem.Location = new System.Drawing.Point(6, 84);
            this.LblClassePersonagem.Name = "ClassePersonagem";
            this.LblClassePersonagem.Size = new System.Drawing.Size(50, 20);
            this.LblClassePersonagem.TabIndex = 1;
            this.LblClassePersonagem.Text = "Classe";
            // 
            // NomePersonagem
            // 
            this.LblNomePersonagem.AutoSize = true;
            this.LblNomePersonagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNomePersonagem.Location = new System.Drawing.Point(6, 48);
            this.LblNomePersonagem.Name = "NomePersonagem";
            this.LblNomePersonagem.Size = new System.Drawing.Size(50, 20);
            this.LblNomePersonagem.TabIndex = 0;
            this.LblNomePersonagem.Text = "Nome";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(447, 335);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(144, 29);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Imprimir Teste";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(1011, 518);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GBCaracteristcs);
            this.Name = "MainScreen";
            this.GBCaracteristcs.ResumeLayout(false);
            this.GBCaracteristcs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}