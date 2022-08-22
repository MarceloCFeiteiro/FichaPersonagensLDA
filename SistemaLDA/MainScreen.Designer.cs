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
            this.LayoutCabecalho = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tlpCharct = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblEment = new System.Windows.Forms.Label();
            this.lblSpellCastSpeed = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblAuraPower = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.txtSpeedCastSpell = new System.Windows.Forms.TextBox();
            this.txtEXP = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.txtAuraPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutCabecalho.SuspendLayout();
            this.tlpCharct.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutCabecalho
            // 
            this.LayoutCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutCabecalho.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LayoutCabecalho.ColumnCount = 3;
            this.LayoutCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.LayoutCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.LayoutCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.LayoutCabecalho.Controls.Add(this.lblHeader, 1, 0);
            this.LayoutCabecalho.Location = new System.Drawing.Point(12, 12);
            this.LayoutCabecalho.Name = "LayoutCabecalho";
            this.LayoutCabecalho.RowCount = 1;
            this.LayoutCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutCabecalho.Size = new System.Drawing.Size(987, 49);
            this.LayoutCabecalho.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(363, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(259, 46);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "SISTEMA LDAP";
            // 
            // tlpCharct
            // 
            this.tlpCharct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharct.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpCharct.ColumnCount = 8;
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.005924F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.92495F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.85801F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51509F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.87304F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14096F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.113204F));
            this.tlpCharct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.005924F));
            this.tlpCharct.Controls.Add(this.lblName, 1, 0);
            this.tlpCharct.Controls.Add(this.lblBreed, 1, 1);
            this.tlpCharct.Controls.Add(this.lblClass, 1, 2);
            this.tlpCharct.Controls.Add(this.lblLevel, 3, 0);
            this.tlpCharct.Controls.Add(this.lblEment, 3, 1);
            this.tlpCharct.Controls.Add(this.lblSpellCastSpeed, 3, 2);
            this.tlpCharct.Controls.Add(this.lblExp, 5, 0);
            this.tlpCharct.Controls.Add(this.lblConstitution, 5, 1);
            this.tlpCharct.Controls.Add(this.lblAuraPower, 5, 2);
            this.tlpCharct.Controls.Add(this.txtName, 2, 0);
            this.tlpCharct.Controls.Add(this.txtBreed, 2, 1);
            this.tlpCharct.Controls.Add(this.txtClass, 2, 2);
            this.tlpCharct.Controls.Add(this.txtLevel, 4, 0);
            this.tlpCharct.Controls.Add(this.txtElement, 4, 1);
            this.tlpCharct.Controls.Add(this.txtSpeedCastSpell, 4, 2);
            this.tlpCharct.Controls.Add(this.txtEXP, 6, 0);
            this.tlpCharct.Controls.Add(this.txtConstitution, 6, 1);
            this.tlpCharct.Controls.Add(this.txtAuraPower, 6, 2);
            this.tlpCharct.Location = new System.Drawing.Point(12, 86);
            this.tlpCharct.Name = "tlpCharct";
            this.tlpCharct.RowCount = 3;
            this.tlpCharct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCharct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCharct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCharct.Size = new System.Drawing.Size(987, 97);
            this.tlpCharct.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblBreed
            // 
            this.lblBreed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(61, 38);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(44, 20);
            this.lblBreed.TabIndex = 1;
            this.lblBreed.Text = "Raça:";
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(52, 70);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(53, 20);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Classe:";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(585, 6);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Nível:";
            // 
            // lblEment
            // 
            this.lblEment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEment.AutoSize = true;
            this.lblEment.Location = new System.Drawing.Point(556, 38);
            this.lblEment.Name = "lblEment";
            this.lblEment.Size = new System.Drawing.Size(75, 20);
            this.lblEment.TabIndex = 4;
            this.lblEment.Text = "Elemento:";
            // 
            // lblSpellCastSpeed
            // 
            this.lblSpellCastSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpellCastSpeed.AutoSize = true;
            this.lblSpellCastSpeed.Location = new System.Drawing.Point(517, 70);
            this.lblSpellCastSpeed.Name = "lblSpellCastSpeed";
            this.lblSpellCastSpeed.Size = new System.Drawing.Size(114, 20);
            this.lblSpellCastSpeed.TabIndex = 5;
            this.lblSpellCastSpeed.Text = "Vel. Conjuração:";
            // 
            // lblExp
            // 
            this.lblExp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(850, 6);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(37, 20);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "EXP:";
            // 
            // lblConstitution
            // 
            this.lblConstitution.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(793, 38);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(94, 20);
            this.lblConstitution.TabIndex = 7;
            this.lblConstitution.Text = "Constituição:";
            // 
            // lblAuraPower
            // 
            this.lblAuraPower.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuraPower.AutoSize = true;
            this.lblAuraPower.Location = new System.Drawing.Point(781, 70);
            this.lblAuraPower.Name = "lblAuraPower";
            this.lblAuraPower.Size = new System.Drawing.Size(106, 20);
            this.lblAuraPower.TabIndex = 8;
            this.lblAuraPower.Text = "Poder de Aura:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(112, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(386, 27);
            this.txtName.TabIndex = 9;
            // 
            // txtBreed
            // 
            this.txtBreed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBreed.Location = new System.Drawing.Point(112, 36);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(386, 27);
            this.txtBreed.TabIndex = 10;
            // 
            // txtClass
            // 
            this.txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClass.Location = new System.Drawing.Point(112, 68);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(386, 27);
            this.txtClass.TabIndex = 11;
            // 
            // txtLevel
            // 
            this.txtLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevel.Location = new System.Drawing.Point(638, 4);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 27);
            this.txtLevel.TabIndex = 12;
            // 
            // txtElement
            // 
            this.txtElement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElement.Location = new System.Drawing.Point(638, 36);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(100, 27);
            this.txtElement.TabIndex = 13;
            // 
            // txtSpeedCastSpell
            // 
            this.txtSpeedCastSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpeedCastSpell.Location = new System.Drawing.Point(638, 68);
            this.txtSpeedCastSpell.Name = "txtSpeedCastSpell";
            this.txtSpeedCastSpell.Size = new System.Drawing.Size(100, 27);
            this.txtSpeedCastSpell.TabIndex = 14;
            // 
            // txtEXP
            // 
            this.txtEXP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEXP.Location = new System.Drawing.Point(894, 4);
            this.txtEXP.Name = "txtEXP";
            this.txtEXP.Size = new System.Drawing.Size(63, 27);
            this.txtEXP.TabIndex = 15;
            // 
            // txtConstitution
            // 
            this.txtConstitution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConstitution.Location = new System.Drawing.Point(894, 36);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(63, 27);
            this.txtConstitution.TabIndex = 16;
            // 
            // txtAuraPower
            // 
            this.txtAuraPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuraPower.Location = new System.Drawing.Point(894, 68);
            this.txtAuraPower.Name = "txtAuraPower";
            this.txtAuraPower.Size = new System.Drawing.Size(63, 27);
            this.txtAuraPower.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(173, 92);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA LDAP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(1011, 518);
            this.Controls.Add(this.tlpCharct);
            this.Controls.Add(this.LayoutCabecalho);
            this.Name = "MainScreen";
            this.LayoutCabecalho.ResumeLayout(false);
            this.LayoutCabecalho.PerformLayout();
            this.tlpCharct.ResumeLayout(false);
            this.tlpCharct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel LayoutCabecalho;
        private TableLayoutPanel tlpCharct;
        private Label lblName;
        private Label lblBreed;
        private Label lblClass;
        private Label lblLevel;
        private Label lblEment;
        private Label lblSpellCastSpeed;
        private Label lblExp;
        private Label lblConstitution;
        private Label lblAuraPower;
        private TextBox txtName;
        private TextBox txtBreed;
        private TextBox txtClass;
        private TextBox txtLevel;
        private TextBox txtElement;
        private TextBox txtSpeedCastSpell;
        private TextBox txtEXP;
        private TextBox txtConstitution;
        private TextBox txtAuraPower;
        private Label lblHeader;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}