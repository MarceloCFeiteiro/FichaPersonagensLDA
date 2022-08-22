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
            this.lblMutableAttributesHeader = new System.Windows.Forms.Label();
            this.tlpMutableAttributesHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMutableAttributesValues = new System.Windows.Forms.TableLayoutPanel();
            this.lblMutableAttributesBase = new System.Windows.Forms.Label();
            this.lblMutableAttributesBreed = new System.Windows.Forms.Label();
            this.lblMutableAttributesClass = new System.Windows.Forms.Label();
            this.lblMutableAttributesEquip = new System.Windows.Forms.Label();
            this.lblMutableAttributesTotalLevel = new System.Windows.Forms.Label();
            this.lblMutableAttributesTotal = new System.Windows.Forms.Label();
            this.lblLifePoints = new System.Windows.Forms.Label();
            this.lblManaPoints = new System.Windows.Forms.Label();
            this.lblPhisicalDamage = new System.Windows.Forms.Label();
            this.lblMagicDamage = new System.Windows.Forms.Label();
            this.lblPhisicalDefense = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDirectDamage = new System.Windows.Forms.Label();
            this.lblDamageReduction = new System.Windows.Forms.Label();
            this.LayoutCabecalho.SuspendLayout();
            this.tlpCharct.SuspendLayout();
            this.tlpMutableAttributesHeader.SuspendLayout();
            this.tlpMutableAttributesValues.SuspendLayout();
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
            // lblMutableAttributesHeader
            // 
            this.lblMutableAttributesHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesHeader.AutoSize = true;
            this.lblMutableAttributesHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMutableAttributesHeader.Location = new System.Drawing.Point(395, 2);
            this.lblMutableAttributesHeader.Name = "lblMutableAttributesHeader";
            this.lblMutableAttributesHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMutableAttributesHeader.Size = new System.Drawing.Size(194, 28);
            this.lblMutableAttributesHeader.TabIndex = 4;
            this.lblMutableAttributesHeader.Text = "Atributos Mutáveis";
            // 
            // tlpMutableAttributesHeader
            // 
            this.tlpMutableAttributesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMutableAttributesHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMutableAttributesHeader.ColumnCount = 3;
            this.tlpMutableAttributesHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tlpMutableAttributesHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.tlpMutableAttributesHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tlpMutableAttributesHeader.Controls.Add(this.lblMutableAttributesHeader, 1, 0);
            this.tlpMutableAttributesHeader.Location = new System.Drawing.Point(12, 208);
            this.tlpMutableAttributesHeader.Name = "tlpMutableAttributesHeader";
            this.tlpMutableAttributesHeader.RowCount = 1;
            this.tlpMutableAttributesHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMutableAttributesHeader.Size = new System.Drawing.Size(987, 33);
            this.tlpMutableAttributesHeader.TabIndex = 4;
            // 
            // tlpMutableAttributesValues
            // 
            this.tlpMutableAttributesValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMutableAttributesValues.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMutableAttributesValues.ColumnCount = 7;
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.95132F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.44625F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMutableAttributesValues.Controls.Add(this.lblMutableAttributesBase, 1, 0);
            this.tlpMutableAttributesValues.Controls.Add(this.lblMutableAttributesBreed, 2, 0);
            this.tlpMutableAttributesValues.Controls.Add(this.lblMutableAttributesClass, 3, 0);
            this.tlpMutableAttributesValues.Controls.Add(this.lblMutableAttributesEquip, 4, 0);
            this.tlpMutableAttributesValues.Controls.Add(this.lblMutableAttributesTotalLevel, 5, 0);
            this.tlpMutableAttributesValues.Controls.Add(this.lblMutableAttributesTotal, 6, 0);
            this.tlpMutableAttributesValues.Controls.Add(this.lblLifePoints, 0, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.lblManaPoints, 0, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.lblPhisicalDamage, 0, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.lblMagicDamage, 0, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.lblPhisicalDefense, 0, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.label7, 0, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.lblDirectDamage, 0, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.lblDamageReduction, 0, 8);
            this.tlpMutableAttributesValues.Location = new System.Drawing.Point(12, 247);
            this.tlpMutableAttributesValues.Name = "tlpMutableAttributesValues";
            this.tlpMutableAttributesValues.RowCount = 9;
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMutableAttributesValues.Size = new System.Drawing.Size(987, 259);
            this.tlpMutableAttributesValues.TabIndex = 5;
            // 
            // lblMutableAttributesBase
            // 
            this.lblMutableAttributesBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesBase.AutoSize = true;
            this.lblMutableAttributesBase.Location = new System.Drawing.Point(209, 4);
            this.lblMutableAttributesBase.Name = "lblMutableAttributesBase";
            this.lblMutableAttributesBase.Size = new System.Drawing.Size(40, 20);
            this.lblMutableAttributesBase.TabIndex = 0;
            this.lblMutableAttributesBase.Text = "Base";
            // 
            // lblMutableAttributesBreed
            // 
            this.lblMutableAttributesBreed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesBreed.AutoSize = true;
            this.lblMutableAttributesBreed.Location = new System.Drawing.Point(330, 4);
            this.lblMutableAttributesBreed.Name = "lblMutableAttributesBreed";
            this.lblMutableAttributesBreed.Size = new System.Drawing.Size(41, 20);
            this.lblMutableAttributesBreed.TabIndex = 1;
            this.lblMutableAttributesBreed.Text = "Raça";
            // 
            // lblMutableAttributesClass
            // 
            this.lblMutableAttributesClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesClass.AutoSize = true;
            this.lblMutableAttributesClass.Location = new System.Drawing.Point(467, 4);
            this.lblMutableAttributesClass.Name = "lblMutableAttributesClass";
            this.lblMutableAttributesClass.Size = new System.Drawing.Size(50, 20);
            this.lblMutableAttributesClass.TabIndex = 2;
            this.lblMutableAttributesClass.Text = "Classe";
            // 
            // lblMutableAttributesEquip
            // 
            this.lblMutableAttributesEquip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesEquip.AutoSize = true;
            this.lblMutableAttributesEquip.Location = new System.Drawing.Point(605, 4);
            this.lblMutableAttributesEquip.Name = "lblMutableAttributesEquip";
            this.lblMutableAttributesEquip.Size = new System.Drawing.Size(55, 20);
            this.lblMutableAttributesEquip.TabIndex = 3;
            this.lblMutableAttributesEquip.Text = "Equipe";
            // 
            // lblMutableAttributesTotalLevel
            // 
            this.lblMutableAttributesTotalLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesTotalLevel.AutoSize = true;
            this.lblMutableAttributesTotalLevel.Location = new System.Drawing.Point(720, 4);
            this.lblMutableAttributesTotalLevel.Name = "lblMutableAttributesTotalLevel";
            this.lblMutableAttributesTotalLevel.Size = new System.Drawing.Size(107, 20);
            this.lblMutableAttributesTotalLevel.TabIndex = 4;
            this.lblMutableAttributesTotalLevel.Text = "Total por Nível";
            // 
            // lblMutableAttributesTotal
            // 
            this.lblMutableAttributesTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesTotal.AutoSize = true;
            this.lblMutableAttributesTotal.Location = new System.Drawing.Point(894, 4);
            this.lblMutableAttributesTotal.Name = "lblMutableAttributesTotal";
            this.lblMutableAttributesTotal.Size = new System.Drawing.Size(42, 20);
            this.lblMutableAttributesTotal.TabIndex = 5;
            this.lblMutableAttributesTotal.Text = "Total";
            // 
            // lblLifePoints
            // 
            this.lblLifePoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLifePoints.AutoSize = true;
            this.lblLifePoints.Location = new System.Drawing.Point(19, 32);
            this.lblLifePoints.Name = "lblLifePoints";
            this.lblLifePoints.Size = new System.Drawing.Size(139, 20);
            this.lblLifePoints.TabIndex = 6;
            this.lblLifePoints.Text = "Pontos de Vida (PV)";
            // 
            // lblManaPoints
            // 
            this.lblManaPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManaPoints.AutoSize = true;
            this.lblManaPoints.Location = new System.Drawing.Point(14, 60);
            this.lblManaPoints.Name = "lblManaPoints";
            this.lblManaPoints.Size = new System.Drawing.Size(150, 20);
            this.lblManaPoints.TabIndex = 7;
            this.lblManaPoints.Text = "Pontos de Mana (PM)";
            // 
            // lblPhisicalDamage
            // 
            this.lblPhisicalDamage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhisicalDamage.AutoSize = true;
            this.lblPhisicalDamage.Location = new System.Drawing.Point(25, 88);
            this.lblPhisicalDamage.Name = "lblPhisicalDamage";
            this.lblPhisicalDamage.Size = new System.Drawing.Size(128, 20);
            this.lblPhisicalDamage.TabIndex = 8;
            this.lblPhisicalDamage.Text = "Dano Físico (DAF)";
            // 
            // lblMagicDamage
            // 
            this.lblMagicDamage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMagicDamage.AutoSize = true;
            this.lblMagicDamage.Location = new System.Drawing.Point(15, 116);
            this.lblMagicDamage.Name = "lblMagicDamage";
            this.lblMagicDamage.Size = new System.Drawing.Size(147, 20);
            this.lblMagicDamage.TabIndex = 9;
            this.lblMagicDamage.Text = "Dano Mágico (DAM)";
            // 
            // lblPhisicalDefense
            // 
            this.lblPhisicalDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhisicalDefense.AutoSize = true;
            this.lblPhisicalDefense.Location = new System.Drawing.Point(21, 144);
            this.lblPhisicalDefense.Name = "lblPhisicalDefense";
            this.lblPhisicalDefense.Size = new System.Drawing.Size(135, 20);
            this.lblPhisicalDefense.TabIndex = 10;
            this.lblPhisicalDefense.Text = "Defesa Física (DEF)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Defesa Mágica (DEM)";
            // 
            // lblDirectDamage
            // 
            this.lblDirectDamage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDirectDamage.AutoSize = true;
            this.lblDirectDamage.Location = new System.Drawing.Point(25, 200);
            this.lblDirectDamage.Name = "lblDirectDamage";
            this.lblDirectDamage.Size = new System.Drawing.Size(127, 20);
            this.lblDirectDamage.TabIndex = 12;
            this.lblDirectDamage.Text = "Dano Direto (DD)";
            // 
            // lblDamageReduction
            // 
            this.lblDamageReduction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDamageReduction.AutoSize = true;
            this.lblDamageReduction.Location = new System.Drawing.Point(8, 231);
            this.lblDamageReduction.Name = "lblDamageReduction";
            this.lblDamageReduction.Size = new System.Drawing.Size(162, 20);
            this.lblDamageReduction.TabIndex = 13;
            this.lblDamageReduction.Text = "Redução de Dano (RD)";
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(1011, 518);
            this.Controls.Add(this.tlpMutableAttributesValues);
            this.Controls.Add(this.tlpMutableAttributesHeader);
            this.Controls.Add(this.tlpCharct);
            this.Controls.Add(this.LayoutCabecalho);
            this.Name = "MainScreen";
            this.LayoutCabecalho.ResumeLayout(false);
            this.LayoutCabecalho.PerformLayout();
            this.tlpCharct.ResumeLayout(false);
            this.tlpCharct.PerformLayout();
            this.tlpMutableAttributesHeader.ResumeLayout(false);
            this.tlpMutableAttributesHeader.PerformLayout();
            this.tlpMutableAttributesValues.ResumeLayout(false);
            this.tlpMutableAttributesValues.PerformLayout();
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
        private Label lblMutableAttributesHeader;
        private TableLayoutPanel tlpMutableAttributesHeader;
        private TableLayoutPanel tlpMutableAttributesValues;
        private Label lblMutableAttributesBase;
        private Label lblMutableAttributesBreed;
        private Label lblMutableAttributesClass;
        private Label lblMutableAttributesEquip;
        private Label lblMutableAttributesTotalLevel;
        private Label lblMutableAttributesTotal;
        private Label lblLifePoints;
        private Label lblManaPoints;
        private Label lblPhisicalDamage;
        private Label lblMagicDamage;
        private Label lblPhisicalDefense;
        private Label label7;
        private Label lblDirectDamage;
        private Label lblDamageReduction;
    }
}