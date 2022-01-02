using System.Windows.Forms;

namespace SistemaLDA
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button BtnSalvar;

        private GroupBox GBCaracteristcs;

        private Label NomePresonagem;
        private Label RacaPersonagem;
        private Label ClassePersonagem;
        private Label Nivel;
        private Label Elemento;
        private Label VelConjuracao;
        private Label Exp;
        private Label Constituicao;
        private Label PoderAura;

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
            this.Exp = new System.Windows.Forms.Label();
            this.Constituicao = new System.Windows.Forms.Label();
            this.PoderAura = new System.Windows.Forms.Label();
            this.TxtNivel = new System.Windows.Forms.TextBox();
            this.TxtElemento = new System.Windows.Forms.TextBox();
            this.TxtVelConjuracao = new System.Windows.Forms.TextBox();
            this.Nivel = new System.Windows.Forms.Label();
            this.Elemento = new System.Windows.Forms.Label();
            this.VelConjuracao = new System.Windows.Forms.Label();
            this.TxtRaca = new System.Windows.Forms.TextBox();
            this.TxtClasse = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.RacaPersonagem = new System.Windows.Forms.Label();
            this.ClassePersonagem = new System.Windows.Forms.Label();
            this.NomePresonagem = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GBCaracteristcs.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCaracteristcs
            // 
            this.GBCaracteristcs.Controls.Add(this.TxtExp);
            this.GBCaracteristcs.Controls.Add(this.TxtConstituicao);
            this.GBCaracteristcs.Controls.Add(this.TxtPoderAura);
            this.GBCaracteristcs.Controls.Add(this.Exp);
            this.GBCaracteristcs.Controls.Add(this.Constituicao);
            this.GBCaracteristcs.Controls.Add(this.PoderAura);
            this.GBCaracteristcs.Controls.Add(this.TxtNivel);
            this.GBCaracteristcs.Controls.Add(this.TxtElemento);
            this.GBCaracteristcs.Controls.Add(this.TxtVelConjuracao);
            this.GBCaracteristcs.Controls.Add(this.Nivel);
            this.GBCaracteristcs.Controls.Add(this.Elemento);
            this.GBCaracteristcs.Controls.Add(this.VelConjuracao);
            this.GBCaracteristcs.Controls.Add(this.TxtRaca);
            this.GBCaracteristcs.Controls.Add(this.TxtClasse);
            this.GBCaracteristcs.Controls.Add(this.TxtNome);
            this.GBCaracteristcs.Controls.Add(this.RacaPersonagem);
            this.GBCaracteristcs.Controls.Add(this.ClassePersonagem);
            this.GBCaracteristcs.Controls.Add(this.NomePresonagem);
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
            this.Exp.AutoSize = true;
            this.Exp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exp.Location = new System.Drawing.Point(686, 48);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(34, 20);
            this.Exp.TabIndex = 14;
            this.Exp.Text = "EXP";
            // 
            // Constituicao
            // 
            this.Constituicao.AutoSize = true;
            this.Constituicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Constituicao.Location = new System.Drawing.Point(686, 84);
            this.Constituicao.Name = "Constituicao";
            this.Constituicao.Size = new System.Drawing.Size(91, 20);
            this.Constituicao.TabIndex = 13;
            this.Constituicao.Text = "Constituicao";
            // 
            // PoderAura
            // 
            this.PoderAura.AutoSize = true;
            this.PoderAura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PoderAura.Location = new System.Drawing.Point(686, 119);
            this.PoderAura.Name = "PoderAura";
            this.PoderAura.Size = new System.Drawing.Size(82, 20);
            this.PoderAura.TabIndex = 12;
            this.PoderAura.Text = "Poder Aura";
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
            this.Nivel.AutoSize = true;
            this.Nivel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nivel.Location = new System.Drawing.Point(336, 119);
            this.Nivel.Name = "Nivel";
            this.Nivel.Size = new System.Drawing.Size(43, 20);
            this.Nivel.TabIndex = 8;
            this.Nivel.Text = "Nível";
            // 
            // Elemento
            // 
            this.Elemento.AutoSize = true;
            this.Elemento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Elemento.Location = new System.Drawing.Point(336, 84);
            this.Elemento.Name = "Elemento";
            this.Elemento.Size = new System.Drawing.Size(72, 20);
            this.Elemento.TabIndex = 7;
            this.Elemento.Text = "Elemento";
            // 
            // VelConjuracao
            // 
            this.VelConjuracao.AutoSize = true;
            this.VelConjuracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VelConjuracao.Location = new System.Drawing.Point(336, 48);
            this.VelConjuracao.Name = "VelConjuracao";
            this.VelConjuracao.Size = new System.Drawing.Size(111, 20);
            this.VelConjuracao.TabIndex = 6;
            this.VelConjuracao.Text = "Vel. Conjuração";
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
            this.RacaPersonagem.AutoSize = true;
            this.RacaPersonagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RacaPersonagem.Location = new System.Drawing.Point(6, 124);
            this.RacaPersonagem.Name = "RacaPersonagem";
            this.RacaPersonagem.Size = new System.Drawing.Size(41, 20);
            this.RacaPersonagem.TabIndex = 2;
            this.RacaPersonagem.Text = "Raça";
            // 
            // ClassePersonagem
            // 
            this.ClassePersonagem.AutoSize = true;
            this.ClassePersonagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassePersonagem.Location = new System.Drawing.Point(6, 84);
            this.ClassePersonagem.Name = "ClassePersonagem";
            this.ClassePersonagem.Size = new System.Drawing.Size(50, 20);
            this.ClassePersonagem.TabIndex = 1;
            this.ClassePersonagem.Text = "Classe";
            // 
            // NomePresonagem
            // 
            this.NomePresonagem.AutoSize = true;
            this.NomePresonagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomePresonagem.Location = new System.Drawing.Point(6, 48);
            this.NomePresonagem.Name = "NomePresonagem";
            this.NomePresonagem.Size = new System.Drawing.Size(50, 20);
            this.NomePresonagem.TabIndex = 0;
            this.NomePresonagem.Text = "Nome";
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