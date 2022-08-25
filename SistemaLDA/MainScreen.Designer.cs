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
            this.LayoutHeader = new System.Windows.Forms.TableLayoutPanel();
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
            this.txtMutableAttributesTotalDEFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalPVValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipeRDValue = new System.Windows.Forms.TextBox();
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
            this.txtMutableAttributesBasePVValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBasePMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBaseDAFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBaseDAMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBaseDEFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBaseDEMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBaseDDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedPVValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedPMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedDAFValue = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedDAMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedDEFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedDEMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedDDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesBreedRDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassPVValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassPMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassDAFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassDAMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassDEFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassDEMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassDDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesClassRDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipePVValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipePMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipeDAFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipeDAMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipeDEFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipeDEMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesEquipeDDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelPVValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelPMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelDAFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelDAMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelDEFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelDEMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelDDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalLevelRDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalPMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalDAFValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalDAMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalDEMValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalDDValue = new System.Windows.Forms.TextBox();
            this.txtMutableAttributesTotalRDValue = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFixAttributesHeader = new System.Windows.Forms.Label();
            this.tlpFixAttributesHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFixAttributesValues = new System.Windows.Forms.TableLayoutPanel();
            this.txtFixAttributesTotalTRAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalVELValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipePCValue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblSpeedPoints = new System.Windows.Forms.Label();
            this.lblPrecisionPoints = new System.Windows.Forms.Label();
            this.lblEvasionPoints = new System.Windows.Forms.Label();
            this.lblFocusPoints = new System.Windows.Forms.Label();
            this.lblTrancePoints = new System.Windows.Forms.Label();
            this.lblConcentrationPoints = new System.Windows.Forms.Label();
            this.lblVigorPoints = new System.Windows.Forms.Label();
            this.lblSConcentrationsPoints = new System.Windows.Forms.Label();
            this.txtFixAttributesBaseVELValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBasePREValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBaseEVAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBaseFOCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBaseTRAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBaseCOMValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBaseVIGValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedVELValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedPREValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedEVAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBasePCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedFOCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedTRAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedCOMValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedVIGValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesBreedPCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassVELValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassPREValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassEVAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassFOCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassTRAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassCOMValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassVIGValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesClassPCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipeVELValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipePREValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipeEVAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipeFOCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipeTRAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipeCOMValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesEquipeVIGValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelVELValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelPREValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelEVAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelFOCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelTRAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelCOMValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelVIGValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalLevelPCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalPREValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalEVAValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalFOCValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalCOMValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalVIGValue = new System.Windows.Forms.TextBox();
            this.txtFixAttributesTotalPCValue = new System.Windows.Forms.TextBox();
            this.LayoutHeader.SuspendLayout();
            this.tlpCharct.SuspendLayout();
            this.tlpMutableAttributesHeader.SuspendLayout();
            this.tlpMutableAttributesValues.SuspendLayout();
            this.tlpFixAttributesHeader.SuspendLayout();
            this.tlpFixAttributesValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutHeader
            // 
            this.LayoutHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LayoutHeader.ColumnCount = 3;
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.LayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.LayoutHeader.Controls.Add(this.lblHeader, 1, 0);
            this.LayoutHeader.Location = new System.Drawing.Point(12, 12);
            this.LayoutHeader.Name = "LayoutHeader";
            this.LayoutHeader.RowCount = 1;
            this.LayoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutHeader.Size = new System.Drawing.Size(987, 49);
            this.LayoutHeader.TabIndex = 2;
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
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.46701F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.22843F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.03553F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.40102F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.tlpMutableAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalDEFValue, 6, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalPVValue, 6, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipeRDValue, 4, 8);
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
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBasePVValue, 1, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBasePMValue, 1, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBaseDAFValue, 1, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBaseDAMValue, 1, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBaseDEFValue, 1, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBaseDEMValue, 1, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBaseDDValue, 1, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedPVValue, 2, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedPMValue, 2, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedDAFValue, 2, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.textBox4, 1, 8);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedDAMValue, 2, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedDEFValue, 2, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedDEMValue, 2, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedDDValue, 2, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesBreedRDValue, 2, 8);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassPVValue, 3, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassPMValue, 3, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassDAFValue, 3, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassDAMValue, 3, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassDEFValue, 3, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassDEMValue, 3, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassDDValue, 3, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesClassRDValue, 3, 8);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipePVValue, 4, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipePMValue, 4, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipeDAFValue, 4, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipeDAMValue, 4, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipeDEFValue, 4, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipeDEMValue, 4, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesEquipeDDValue, 4, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelPVValue, 5, 1);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelPMValue, 5, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelDAFValue, 5, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelDAMValue, 5, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelDEFValue, 5, 5);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelDEMValue, 5, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelDDValue, 5, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalLevelRDValue, 5, 8);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalPMValue, 6, 2);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalDAFValue, 6, 3);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalDAMValue, 6, 4);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalDEMValue, 6, 6);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalDDValue, 6, 7);
            this.tlpMutableAttributesValues.Controls.Add(this.txtMutableAttributesTotalRDValue, 6, 8);
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
            this.tlpMutableAttributesValues.Size = new System.Drawing.Size(987, 303);
            this.tlpMutableAttributesValues.TabIndex = 5;
            // 
            // txtMutableAttributesTotalDEFValue
            // 
            this.txtMutableAttributesTotalDEFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalDEFValue.Location = new System.Drawing.Point(878, 169);
            this.txtMutableAttributesTotalDEFValue.Name = "txtMutableAttributesTotalDEFValue";
            this.txtMutableAttributesTotalDEFValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalDEFValue.TabIndex = 23;
            // 
            // txtMutableAttributesTotalPVValue
            // 
            this.txtMutableAttributesTotalPVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalPVValue.Location = new System.Drawing.Point(878, 37);
            this.txtMutableAttributesTotalPVValue.Name = "txtMutableAttributesTotalPVValue";
            this.txtMutableAttributesTotalPVValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalPVValue.TabIndex = 23;
            // 
            // txtMutableAttributesEquipeRDValue
            // 
            this.txtMutableAttributesEquipeRDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipeRDValue.Location = new System.Drawing.Point(590, 268);
            this.txtMutableAttributesEquipeRDValue.Name = "txtMutableAttributesEquipeRDValue";
            this.txtMutableAttributesEquipeRDValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipeRDValue.TabIndex = 45;
            // 
            // lblMutableAttributesBase
            // 
            this.lblMutableAttributesBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesBase.AutoSize = true;
            this.lblMutableAttributesBase.Location = new System.Drawing.Point(245, 7);
            this.lblMutableAttributesBase.Name = "lblMutableAttributesBase";
            this.lblMutableAttributesBase.Size = new System.Drawing.Size(40, 20);
            this.lblMutableAttributesBase.TabIndex = 0;
            this.lblMutableAttributesBase.Text = "Base";
            // 
            // lblMutableAttributesBreed
            // 
            this.lblMutableAttributesBreed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesBreed.AutoSize = true;
            this.lblMutableAttributesBreed.Location = new System.Drawing.Point(360, 7);
            this.lblMutableAttributesBreed.Name = "lblMutableAttributesBreed";
            this.lblMutableAttributesBreed.Size = new System.Drawing.Size(41, 20);
            this.lblMutableAttributesBreed.TabIndex = 1;
            this.lblMutableAttributesBreed.Text = "Raça";
            // 
            // lblMutableAttributesClass
            // 
            this.lblMutableAttributesClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesClass.AutoSize = true;
            this.lblMutableAttributesClass.Location = new System.Drawing.Point(488, 7);
            this.lblMutableAttributesClass.Name = "lblMutableAttributesClass";
            this.lblMutableAttributesClass.Size = new System.Drawing.Size(50, 20);
            this.lblMutableAttributesClass.TabIndex = 2;
            this.lblMutableAttributesClass.Text = "Classe";
            // 
            // lblMutableAttributesEquip
            // 
            this.lblMutableAttributesEquip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesEquip.AutoSize = true;
            this.lblMutableAttributesEquip.Location = new System.Drawing.Point(630, 7);
            this.lblMutableAttributesEquip.Name = "lblMutableAttributesEquip";
            this.lblMutableAttributesEquip.Size = new System.Drawing.Size(55, 20);
            this.lblMutableAttributesEquip.TabIndex = 3;
            this.lblMutableAttributesEquip.Text = "Equipe";
            // 
            // lblMutableAttributesTotalLevel
            // 
            this.lblMutableAttributesTotalLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesTotalLevel.AutoSize = true;
            this.lblMutableAttributesTotalLevel.Location = new System.Drawing.Point(748, 7);
            this.lblMutableAttributesTotalLevel.Name = "lblMutableAttributesTotalLevel";
            this.lblMutableAttributesTotalLevel.Size = new System.Drawing.Size(107, 20);
            this.lblMutableAttributesTotalLevel.TabIndex = 4;
            this.lblMutableAttributesTotalLevel.Text = "Total por Nível";
            // 
            // lblMutableAttributesTotal
            // 
            this.lblMutableAttributesTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMutableAttributesTotal.AutoSize = true;
            this.lblMutableAttributesTotal.Location = new System.Drawing.Point(909, 7);
            this.lblMutableAttributesTotal.Name = "lblMutableAttributesTotal";
            this.lblMutableAttributesTotal.Size = new System.Drawing.Size(42, 20);
            this.lblMutableAttributesTotal.TabIndex = 5;
            this.lblMutableAttributesTotal.Text = "Total";
            // 
            // lblLifePoints
            // 
            this.lblLifePoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLifePoints.AutoSize = true;
            this.lblLifePoints.Location = new System.Drawing.Point(4, 40);
            this.lblLifePoints.Name = "lblLifePoints";
            this.lblLifePoints.Size = new System.Drawing.Size(139, 20);
            this.lblLifePoints.TabIndex = 6;
            this.lblLifePoints.Text = "Pontos de Vida (PV)";
            // 
            // lblManaPoints
            // 
            this.lblManaPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblManaPoints.AutoSize = true;
            this.lblManaPoints.Location = new System.Drawing.Point(4, 73);
            this.lblManaPoints.Name = "lblManaPoints";
            this.lblManaPoints.Size = new System.Drawing.Size(150, 20);
            this.lblManaPoints.TabIndex = 7;
            this.lblManaPoints.Text = "Pontos de Mana (PM)";
            // 
            // lblPhisicalDamage
            // 
            this.lblPhisicalDamage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhisicalDamage.AutoSize = true;
            this.lblPhisicalDamage.Location = new System.Drawing.Point(4, 106);
            this.lblPhisicalDamage.Name = "lblPhisicalDamage";
            this.lblPhisicalDamage.Size = new System.Drawing.Size(128, 20);
            this.lblPhisicalDamage.TabIndex = 8;
            this.lblPhisicalDamage.Text = "Dano Físico (DAF)";
            // 
            // lblMagicDamage
            // 
            this.lblMagicDamage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMagicDamage.AutoSize = true;
            this.lblMagicDamage.Location = new System.Drawing.Point(4, 139);
            this.lblMagicDamage.Name = "lblMagicDamage";
            this.lblMagicDamage.Size = new System.Drawing.Size(147, 20);
            this.lblMagicDamage.TabIndex = 9;
            this.lblMagicDamage.Text = "Dano Mágico (DAM)";
            // 
            // lblPhisicalDefense
            // 
            this.lblPhisicalDefense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhisicalDefense.AutoSize = true;
            this.lblPhisicalDefense.Location = new System.Drawing.Point(4, 172);
            this.lblPhisicalDefense.Name = "lblPhisicalDefense";
            this.lblPhisicalDefense.Size = new System.Drawing.Size(135, 20);
            this.lblPhisicalDefense.TabIndex = 10;
            this.lblPhisicalDefense.Text = "Defesa Física (DEF)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Defesa Mágica (DEM)";
            // 
            // lblDirectDamage
            // 
            this.lblDirectDamage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDirectDamage.AutoSize = true;
            this.lblDirectDamage.Location = new System.Drawing.Point(4, 238);
            this.lblDirectDamage.Name = "lblDirectDamage";
            this.lblDirectDamage.Size = new System.Drawing.Size(127, 20);
            this.lblDirectDamage.TabIndex = 12;
            this.lblDirectDamage.Text = "Dano Direto (DD)";
            // 
            // lblDamageReduction
            // 
            this.lblDamageReduction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDamageReduction.AutoSize = true;
            this.lblDamageReduction.Location = new System.Drawing.Point(4, 273);
            this.lblDamageReduction.Name = "lblDamageReduction";
            this.lblDamageReduction.Size = new System.Drawing.Size(202, 20);
            this.lblDamageReduction.TabIndex = 13;
            this.lblDamageReduction.Text = "Redução de Dano (RD)          ";
            // 
            // txtMutableAttributesBasePVValue
            // 
            this.txtMutableAttributesBasePVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBasePVValue.Location = new System.Drawing.Point(213, 37);
            this.txtMutableAttributesBasePVValue.Name = "txtMutableAttributesBasePVValue";
            this.txtMutableAttributesBasePVValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBasePVValue.TabIndex = 14;
            // 
            // txtMutableAttributesBasePMValue
            // 
            this.txtMutableAttributesBasePMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBasePMValue.Location = new System.Drawing.Point(213, 70);
            this.txtMutableAttributesBasePMValue.Name = "txtMutableAttributesBasePMValue";
            this.txtMutableAttributesBasePMValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBasePMValue.TabIndex = 15;
            // 
            // txtMutableAttributesBaseDAFValue
            // 
            this.txtMutableAttributesBaseDAFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBaseDAFValue.Location = new System.Drawing.Point(213, 103);
            this.txtMutableAttributesBaseDAFValue.Name = "txtMutableAttributesBaseDAFValue";
            this.txtMutableAttributesBaseDAFValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBaseDAFValue.TabIndex = 16;
            // 
            // txtMutableAttributesBaseDAMValue
            // 
            this.txtMutableAttributesBaseDAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBaseDAMValue.Location = new System.Drawing.Point(213, 136);
            this.txtMutableAttributesBaseDAMValue.Name = "txtMutableAttributesBaseDAMValue";
            this.txtMutableAttributesBaseDAMValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBaseDAMValue.TabIndex = 17;
            // 
            // txtMutableAttributesBaseDEFValue
            // 
            this.txtMutableAttributesBaseDEFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBaseDEFValue.Location = new System.Drawing.Point(213, 169);
            this.txtMutableAttributesBaseDEFValue.Name = "txtMutableAttributesBaseDEFValue";
            this.txtMutableAttributesBaseDEFValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBaseDEFValue.TabIndex = 18;
            // 
            // txtMutableAttributesBaseDEMValue
            // 
            this.txtMutableAttributesBaseDEMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBaseDEMValue.Location = new System.Drawing.Point(213, 202);
            this.txtMutableAttributesBaseDEMValue.Name = "txtMutableAttributesBaseDEMValue";
            this.txtMutableAttributesBaseDEMValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBaseDEMValue.TabIndex = 19;
            // 
            // txtMutableAttributesBaseDDValue
            // 
            this.txtMutableAttributesBaseDDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBaseDDValue.Location = new System.Drawing.Point(213, 235);
            this.txtMutableAttributesBaseDDValue.Name = "txtMutableAttributesBaseDDValue";
            this.txtMutableAttributesBaseDDValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesBaseDDValue.TabIndex = 20;
            // 
            // txtMutableAttributesBreedPVValue
            // 
            this.txtMutableAttributesBreedPVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedPVValue.Location = new System.Drawing.Point(325, 37);
            this.txtMutableAttributesBreedPVValue.Name = "txtMutableAttributesBreedPVValue";
            this.txtMutableAttributesBreedPVValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedPVValue.TabIndex = 22;
            // 
            // txtMutableAttributesBreedPMValue
            // 
            this.txtMutableAttributesBreedPMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedPMValue.Location = new System.Drawing.Point(325, 70);
            this.txtMutableAttributesBreedPMValue.Name = "txtMutableAttributesBreedPMValue";
            this.txtMutableAttributesBreedPMValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedPMValue.TabIndex = 23;
            // 
            // txtMutableAttributesBreedDAFValue
            // 
            this.txtMutableAttributesBreedDAFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedDAFValue.Location = new System.Drawing.Point(325, 103);
            this.txtMutableAttributesBreedDAFValue.Name = "txtMutableAttributesBreedDAFValue";
            this.txtMutableAttributesBreedDAFValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedDAFValue.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(213, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 27);
            this.textBox4.TabIndex = 25;
            // 
            // txtMutableAttributesBreedDAMValue
            // 
            this.txtMutableAttributesBreedDAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedDAMValue.Location = new System.Drawing.Point(325, 136);
            this.txtMutableAttributesBreedDAMValue.Name = "txtMutableAttributesBreedDAMValue";
            this.txtMutableAttributesBreedDAMValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedDAMValue.TabIndex = 21;
            // 
            // txtMutableAttributesBreedDEFValue
            // 
            this.txtMutableAttributesBreedDEFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedDEFValue.Location = new System.Drawing.Point(325, 169);
            this.txtMutableAttributesBreedDEFValue.Name = "txtMutableAttributesBreedDEFValue";
            this.txtMutableAttributesBreedDEFValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedDEFValue.TabIndex = 26;
            // 
            // txtMutableAttributesBreedDEMValue
            // 
            this.txtMutableAttributesBreedDEMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedDEMValue.Location = new System.Drawing.Point(325, 202);
            this.txtMutableAttributesBreedDEMValue.Name = "txtMutableAttributesBreedDEMValue";
            this.txtMutableAttributesBreedDEMValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedDEMValue.TabIndex = 27;
            // 
            // txtMutableAttributesBreedDDValue
            // 
            this.txtMutableAttributesBreedDDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedDDValue.Location = new System.Drawing.Point(325, 235);
            this.txtMutableAttributesBreedDDValue.Name = "txtMutableAttributesBreedDDValue";
            this.txtMutableAttributesBreedDDValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedDDValue.TabIndex = 28;
            // 
            // txtMutableAttributesBreedRDValue
            // 
            this.txtMutableAttributesBreedRDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesBreedRDValue.Location = new System.Drawing.Point(325, 268);
            this.txtMutableAttributesBreedRDValue.Name = "txtMutableAttributesBreedRDValue";
            this.txtMutableAttributesBreedRDValue.Size = new System.Drawing.Size(111, 27);
            this.txtMutableAttributesBreedRDValue.TabIndex = 29;
            // 
            // txtMutableAttributesClassPVValue
            // 
            this.txtMutableAttributesClassPVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassPVValue.Location = new System.Drawing.Point(443, 37);
            this.txtMutableAttributesClassPVValue.Name = "txtMutableAttributesClassPVValue";
            this.txtMutableAttributesClassPVValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassPVValue.TabIndex = 30;
            // 
            // txtMutableAttributesClassPMValue
            // 
            this.txtMutableAttributesClassPMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassPMValue.Location = new System.Drawing.Point(443, 70);
            this.txtMutableAttributesClassPMValue.Name = "txtMutableAttributesClassPMValue";
            this.txtMutableAttributesClassPMValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassPMValue.TabIndex = 31;
            // 
            // txtMutableAttributesClassDAFValue
            // 
            this.txtMutableAttributesClassDAFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassDAFValue.Location = new System.Drawing.Point(443, 103);
            this.txtMutableAttributesClassDAFValue.Name = "txtMutableAttributesClassDAFValue";
            this.txtMutableAttributesClassDAFValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassDAFValue.TabIndex = 32;
            // 
            // txtMutableAttributesClassDAMValue
            // 
            this.txtMutableAttributesClassDAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassDAMValue.Location = new System.Drawing.Point(443, 136);
            this.txtMutableAttributesClassDAMValue.Name = "txtMutableAttributesClassDAMValue";
            this.txtMutableAttributesClassDAMValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassDAMValue.TabIndex = 33;
            // 
            // txtMutableAttributesClassDEFValue
            // 
            this.txtMutableAttributesClassDEFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassDEFValue.Location = new System.Drawing.Point(443, 169);
            this.txtMutableAttributesClassDEFValue.Name = "txtMutableAttributesClassDEFValue";
            this.txtMutableAttributesClassDEFValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassDEFValue.TabIndex = 34;
            // 
            // txtMutableAttributesClassDEMValue
            // 
            this.txtMutableAttributesClassDEMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassDEMValue.Location = new System.Drawing.Point(443, 202);
            this.txtMutableAttributesClassDEMValue.Name = "txtMutableAttributesClassDEMValue";
            this.txtMutableAttributesClassDEMValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassDEMValue.TabIndex = 35;
            // 
            // txtMutableAttributesClassDDValue
            // 
            this.txtMutableAttributesClassDDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassDDValue.Location = new System.Drawing.Point(443, 235);
            this.txtMutableAttributesClassDDValue.Name = "txtMutableAttributesClassDDValue";
            this.txtMutableAttributesClassDDValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassDDValue.TabIndex = 36;
            // 
            // txtMutableAttributesClassRDValue
            // 
            this.txtMutableAttributesClassRDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesClassRDValue.Location = new System.Drawing.Point(443, 268);
            this.txtMutableAttributesClassRDValue.Name = "txtMutableAttributesClassRDValue";
            this.txtMutableAttributesClassRDValue.Size = new System.Drawing.Size(140, 27);
            this.txtMutableAttributesClassRDValue.TabIndex = 37;
            // 
            // txtMutableAttributesEquipePVValue
            // 
            this.txtMutableAttributesEquipePVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipePVValue.Location = new System.Drawing.Point(590, 37);
            this.txtMutableAttributesEquipePVValue.Name = "txtMutableAttributesEquipePVValue";
            this.txtMutableAttributesEquipePVValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipePVValue.TabIndex = 38;
            // 
            // txtMutableAttributesEquipePMValue
            // 
            this.txtMutableAttributesEquipePMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipePMValue.Location = new System.Drawing.Point(590, 70);
            this.txtMutableAttributesEquipePMValue.Name = "txtMutableAttributesEquipePMValue";
            this.txtMutableAttributesEquipePMValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipePMValue.TabIndex = 39;
            // 
            // txtMutableAttributesEquipeDAFValue
            // 
            this.txtMutableAttributesEquipeDAFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipeDAFValue.Location = new System.Drawing.Point(590, 103);
            this.txtMutableAttributesEquipeDAFValue.Name = "txtMutableAttributesEquipeDAFValue";
            this.txtMutableAttributesEquipeDAFValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipeDAFValue.TabIndex = 40;
            // 
            // txtMutableAttributesEquipeDAMValue
            // 
            this.txtMutableAttributesEquipeDAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipeDAMValue.Location = new System.Drawing.Point(590, 136);
            this.txtMutableAttributesEquipeDAMValue.Name = "txtMutableAttributesEquipeDAMValue";
            this.txtMutableAttributesEquipeDAMValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipeDAMValue.TabIndex = 41;
            // 
            // txtMutableAttributesEquipeDEFValue
            // 
            this.txtMutableAttributesEquipeDEFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipeDEFValue.Location = new System.Drawing.Point(590, 169);
            this.txtMutableAttributesEquipeDEFValue.Name = "txtMutableAttributesEquipeDEFValue";
            this.txtMutableAttributesEquipeDEFValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipeDEFValue.TabIndex = 42;
            // 
            // txtMutableAttributesEquipeDEMValue
            // 
            this.txtMutableAttributesEquipeDEMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipeDEMValue.Location = new System.Drawing.Point(590, 202);
            this.txtMutableAttributesEquipeDEMValue.Name = "txtMutableAttributesEquipeDEMValue";
            this.txtMutableAttributesEquipeDEMValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipeDEMValue.TabIndex = 43;
            // 
            // txtMutableAttributesEquipeDDValue
            // 
            this.txtMutableAttributesEquipeDDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesEquipeDDValue.Location = new System.Drawing.Point(590, 235);
            this.txtMutableAttributesEquipeDDValue.Name = "txtMutableAttributesEquipeDDValue";
            this.txtMutableAttributesEquipeDDValue.Size = new System.Drawing.Size(135, 27);
            this.txtMutableAttributesEquipeDDValue.TabIndex = 44;
            // 
            // txtMutableAttributesTotalLevelPVValue
            // 
            this.txtMutableAttributesTotalLevelPVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelPVValue.Location = new System.Drawing.Point(732, 37);
            this.txtMutableAttributesTotalLevelPVValue.Name = "txtMutableAttributesTotalLevelPVValue";
            this.txtMutableAttributesTotalLevelPVValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelPVValue.TabIndex = 46;
            // 
            // txtMutableAttributesTotalLevelPMValue
            // 
            this.txtMutableAttributesTotalLevelPMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelPMValue.Location = new System.Drawing.Point(732, 70);
            this.txtMutableAttributesTotalLevelPMValue.Name = "txtMutableAttributesTotalLevelPMValue";
            this.txtMutableAttributesTotalLevelPMValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelPMValue.TabIndex = 47;
            // 
            // txtMutableAttributesTotalLevelDAFValue
            // 
            this.txtMutableAttributesTotalLevelDAFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelDAFValue.Location = new System.Drawing.Point(732, 103);
            this.txtMutableAttributesTotalLevelDAFValue.Name = "txtMutableAttributesTotalLevelDAFValue";
            this.txtMutableAttributesTotalLevelDAFValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelDAFValue.TabIndex = 48;
            // 
            // txtMutableAttributesTotalLevelDAMValue
            // 
            this.txtMutableAttributesTotalLevelDAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelDAMValue.Location = new System.Drawing.Point(732, 136);
            this.txtMutableAttributesTotalLevelDAMValue.Name = "txtMutableAttributesTotalLevelDAMValue";
            this.txtMutableAttributesTotalLevelDAMValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelDAMValue.TabIndex = 49;
            // 
            // txtMutableAttributesTotalLevelDEFValue
            // 
            this.txtMutableAttributesTotalLevelDEFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelDEFValue.Location = new System.Drawing.Point(732, 169);
            this.txtMutableAttributesTotalLevelDEFValue.Name = "txtMutableAttributesTotalLevelDEFValue";
            this.txtMutableAttributesTotalLevelDEFValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelDEFValue.TabIndex = 50;
            // 
            // txtMutableAttributesTotalLevelDEMValue
            // 
            this.txtMutableAttributesTotalLevelDEMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelDEMValue.Location = new System.Drawing.Point(732, 202);
            this.txtMutableAttributesTotalLevelDEMValue.Name = "txtMutableAttributesTotalLevelDEMValue";
            this.txtMutableAttributesTotalLevelDEMValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelDEMValue.TabIndex = 51;
            // 
            // txtMutableAttributesTotalLevelDDValue
            // 
            this.txtMutableAttributesTotalLevelDDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelDDValue.Location = new System.Drawing.Point(732, 235);
            this.txtMutableAttributesTotalLevelDDValue.Name = "txtMutableAttributesTotalLevelDDValue";
            this.txtMutableAttributesTotalLevelDDValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelDDValue.TabIndex = 52;
            // 
            // txtMutableAttributesTotalLevelRDValue
            // 
            this.txtMutableAttributesTotalLevelRDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalLevelRDValue.Location = new System.Drawing.Point(732, 268);
            this.txtMutableAttributesTotalLevelRDValue.Name = "txtMutableAttributesTotalLevelRDValue";
            this.txtMutableAttributesTotalLevelRDValue.Size = new System.Drawing.Size(139, 27);
            this.txtMutableAttributesTotalLevelRDValue.TabIndex = 53;
            // 
            // txtMutableAttributesTotalPMValue
            // 
            this.txtMutableAttributesTotalPMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalPMValue.Location = new System.Drawing.Point(878, 70);
            this.txtMutableAttributesTotalPMValue.Name = "txtMutableAttributesTotalPMValue";
            this.txtMutableAttributesTotalPMValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalPMValue.TabIndex = 54;
            // 
            // txtMutableAttributesTotalDAFValue
            // 
            this.txtMutableAttributesTotalDAFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalDAFValue.Location = new System.Drawing.Point(878, 103);
            this.txtMutableAttributesTotalDAFValue.Name = "txtMutableAttributesTotalDAFValue";
            this.txtMutableAttributesTotalDAFValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalDAFValue.TabIndex = 55;
            // 
            // txtMutableAttributesTotalDAMValue
            // 
            this.txtMutableAttributesTotalDAMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalDAMValue.Location = new System.Drawing.Point(878, 136);
            this.txtMutableAttributesTotalDAMValue.Name = "txtMutableAttributesTotalDAMValue";
            this.txtMutableAttributesTotalDAMValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalDAMValue.TabIndex = 56;
            // 
            // txtMutableAttributesTotalDEMValue
            // 
            this.txtMutableAttributesTotalDEMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalDEMValue.Location = new System.Drawing.Point(878, 202);
            this.txtMutableAttributesTotalDEMValue.Name = "txtMutableAttributesTotalDEMValue";
            this.txtMutableAttributesTotalDEMValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalDEMValue.TabIndex = 57;
            // 
            // txtMutableAttributesTotalDDValue
            // 
            this.txtMutableAttributesTotalDDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalDDValue.Location = new System.Drawing.Point(878, 235);
            this.txtMutableAttributesTotalDDValue.Name = "txtMutableAttributesTotalDDValue";
            this.txtMutableAttributesTotalDDValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalDDValue.TabIndex = 58;
            // 
            // txtMutableAttributesTotalRDValue
            // 
            this.txtMutableAttributesTotalRDValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMutableAttributesTotalRDValue.Location = new System.Drawing.Point(878, 268);
            this.txtMutableAttributesTotalRDValue.Name = "txtMutableAttributesTotalRDValue";
            this.txtMutableAttributesTotalRDValue.Size = new System.Drawing.Size(105, 27);
            this.txtMutableAttributesTotalRDValue.TabIndex = 59;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(850, 650);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 27);
            this.textBox1.TabIndex = 85;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(850, 518);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 27);
            this.textBox2.TabIndex = 86;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(568, 749);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 27);
            this.textBox3.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Raça";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Classe";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Equipe";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Total por Nível";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Pontos de Vida (PV)";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Pontos de Mana (PM)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Dano Físico (DAF)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 70;
            this.label12.Text = "Dano Mágico (DAM)";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 653);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 71;
            this.label13.Text = "Defesa Física (DEF)";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 686);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "Defesa Mágica (DEM)";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 719);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = "Dano Direto (DD)";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 754);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Redução de Dano (RD)";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(183, 518);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 27);
            this.textBox5.TabIndex = 75;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(183, 551);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 27);
            this.textBox6.TabIndex = 76;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(183, 584);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(120, 27);
            this.textBox7.TabIndex = 77;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(183, 617);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(120, 27);
            this.textBox8.TabIndex = 78;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(183, 650);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(120, 27);
            this.textBox9.TabIndex = 79;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(183, 683);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(120, 27);
            this.textBox10.TabIndex = 80;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(183, 716);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(120, 27);
            this.textBox11.TabIndex = 81;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(310, 518);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(110, 27);
            this.textBox12.TabIndex = 83;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Location = new System.Drawing.Point(310, 551);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(110, 27);
            this.textBox13.TabIndex = 84;
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Location = new System.Drawing.Point(310, 584);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(110, 27);
            this.textBox14.TabIndex = 87;
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.Location = new System.Drawing.Point(183, 749);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(120, 27);
            this.textBox15.TabIndex = 88;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.Location = new System.Drawing.Point(310, 617);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(110, 27);
            this.textBox16.TabIndex = 82;
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Location = new System.Drawing.Point(310, 650);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(110, 27);
            this.textBox17.TabIndex = 89;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.Location = new System.Drawing.Point(310, 683);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(110, 27);
            this.textBox18.TabIndex = 90;
            // 
            // textBox19
            // 
            this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox19.Location = new System.Drawing.Point(310, 716);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(110, 27);
            this.textBox19.TabIndex = 91;
            // 
            // textBox20
            // 
            this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox20.Location = new System.Drawing.Point(310, 749);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(110, 27);
            this.textBox20.TabIndex = 92;
            // 
            // textBox21
            // 
            this.textBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox21.Location = new System.Drawing.Point(427, 518);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(134, 27);
            this.textBox21.TabIndex = 93;
            // 
            // textBox22
            // 
            this.textBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox22.Location = new System.Drawing.Point(427, 551);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(134, 27);
            this.textBox22.TabIndex = 94;
            // 
            // textBox23
            // 
            this.textBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox23.Location = new System.Drawing.Point(427, 584);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(134, 27);
            this.textBox23.TabIndex = 95;
            // 
            // textBox24
            // 
            this.textBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox24.Location = new System.Drawing.Point(427, 617);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(134, 27);
            this.textBox24.TabIndex = 96;
            // 
            // textBox25
            // 
            this.textBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox25.Location = new System.Drawing.Point(427, 650);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(134, 27);
            this.textBox25.TabIndex = 97;
            // 
            // textBox26
            // 
            this.textBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox26.Location = new System.Drawing.Point(427, 683);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(134, 27);
            this.textBox26.TabIndex = 98;
            // 
            // textBox27
            // 
            this.textBox27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox27.Location = new System.Drawing.Point(427, 716);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(134, 27);
            this.textBox27.TabIndex = 99;
            // 
            // textBox28
            // 
            this.textBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox28.Location = new System.Drawing.Point(427, 749);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(134, 27);
            this.textBox28.TabIndex = 100;
            // 
            // textBox29
            // 
            this.textBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox29.Location = new System.Drawing.Point(568, 518);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(134, 27);
            this.textBox29.TabIndex = 101;
            // 
            // textBox30
            // 
            this.textBox30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox30.Location = new System.Drawing.Point(568, 551);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(134, 27);
            this.textBox30.TabIndex = 102;
            // 
            // textBox31
            // 
            this.textBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox31.Location = new System.Drawing.Point(568, 584);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(134, 27);
            this.textBox31.TabIndex = 103;
            // 
            // textBox32
            // 
            this.textBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox32.Location = new System.Drawing.Point(568, 617);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(134, 27);
            this.textBox32.TabIndex = 104;
            // 
            // textBox33
            // 
            this.textBox33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox33.Location = new System.Drawing.Point(568, 650);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(134, 27);
            this.textBox33.TabIndex = 105;
            // 
            // textBox34
            // 
            this.textBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox34.Location = new System.Drawing.Point(568, 683);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(134, 27);
            this.textBox34.TabIndex = 106;
            // 
            // textBox35
            // 
            this.textBox35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox35.Location = new System.Drawing.Point(568, 716);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(134, 27);
            this.textBox35.TabIndex = 107;
            // 
            // textBox36
            // 
            this.textBox36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox36.Location = new System.Drawing.Point(709, 518);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(134, 27);
            this.textBox36.TabIndex = 109;
            // 
            // textBox37
            // 
            this.textBox37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox37.Location = new System.Drawing.Point(709, 584);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(134, 27);
            this.textBox37.TabIndex = 111;
            // 
            // textBox38
            // 
            this.textBox38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox38.Location = new System.Drawing.Point(709, 617);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(134, 27);
            this.textBox38.TabIndex = 112;
            // 
            // textBox39
            // 
            this.textBox39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox39.Location = new System.Drawing.Point(709, 650);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(134, 27);
            this.textBox39.TabIndex = 113;
            // 
            // textBox40
            // 
            this.textBox40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox40.Location = new System.Drawing.Point(709, 683);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(134, 27);
            this.textBox40.TabIndex = 114;
            // 
            // textBox41
            // 
            this.textBox41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox41.Location = new System.Drawing.Point(709, 716);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(134, 27);
            this.textBox41.TabIndex = 115;
            // 
            // textBox42
            // 
            this.textBox42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox42.Location = new System.Drawing.Point(709, 749);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(134, 27);
            this.textBox42.TabIndex = 116;
            // 
            // textBox43
            // 
            this.textBox43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox43.Location = new System.Drawing.Point(850, 551);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(135, 27);
            this.textBox43.TabIndex = 117;
            // 
            // textBox44
            // 
            this.textBox44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox44.Location = new System.Drawing.Point(850, 584);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(135, 27);
            this.textBox44.TabIndex = 118;
            // 
            // textBox45
            // 
            this.textBox45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox45.Location = new System.Drawing.Point(850, 617);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(135, 27);
            this.textBox45.TabIndex = 119;
            // 
            // textBox46
            // 
            this.textBox46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox46.Location = new System.Drawing.Point(850, 683);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(135, 27);
            this.textBox46.TabIndex = 120;
            // 
            // textBox47
            // 
            this.textBox47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox47.Location = new System.Drawing.Point(850, 716);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(135, 27);
            this.textBox47.TabIndex = 121;
            // 
            // textBox48
            // 
            this.textBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox48.Location = new System.Drawing.Point(850, 749);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(135, 27);
            this.textBox48.TabIndex = 122;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(46, 22);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(107, 56);
            this.label17.TabIndex = 4;
            this.label17.Text = "Atributos Mutáveis";
            // 
            // textBox49
            // 
            this.textBox49.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox49.Location = new System.Drawing.Point(709, 551);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(134, 27);
            this.textBox49.TabIndex = 110;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(46, 22);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(107, 56);
            this.label18.TabIndex = 4;
            this.label18.Text = "Atributos Mutáveis";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(46, 22);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(107, 56);
            this.label19.TabIndex = 4;
            this.label19.Text = "Atributos Mutáveis";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblFixAttributesHeader
            // 
            this.lblFixAttributesHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFixAttributesHeader.AutoSize = true;
            this.lblFixAttributesHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFixAttributesHeader.Location = new System.Drawing.Point(415, 2);
            this.lblFixAttributesHeader.Name = "lblFixAttributesHeader";
            this.lblFixAttributesHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFixAttributesHeader.Size = new System.Drawing.Size(155, 28);
            this.lblFixAttributesHeader.TabIndex = 4;
            this.lblFixAttributesHeader.Text = "Atributos Fixos";
            // 
            // tlpFixAttributesHeader
            // 
            this.tlpFixAttributesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFixAttributesHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpFixAttributesHeader.ColumnCount = 3;
            this.tlpFixAttributesHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tlpFixAttributesHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.78014F));
            this.tlpFixAttributesHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.109929F));
            this.tlpFixAttributesHeader.Controls.Add(this.lblFixAttributesHeader, 1, 0);
            this.tlpFixAttributesHeader.Location = new System.Drawing.Point(12, 575);
            this.tlpFixAttributesHeader.Name = "tlpFixAttributesHeader";
            this.tlpFixAttributesHeader.RowCount = 1;
            this.tlpFixAttributesHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFixAttributesHeader.Size = new System.Drawing.Size(987, 33);
            this.tlpFixAttributesHeader.TabIndex = 6;
            // 
            // tlpFixAttributesValues
            // 
            this.tlpFixAttributesValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFixAttributesValues.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpFixAttributesValues.ColumnCount = 7;
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21281F));
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.6788F));
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.90868F));
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.90868F));
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.90868F));
            this.tlpFixAttributesValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.38235F));
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalTRAValue, 6, 5);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalVELValue, 6, 1);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipePCValue, 4, 8);
            this.tlpFixAttributesValues.Controls.Add(this.label21, 1, 0);
            this.tlpFixAttributesValues.Controls.Add(this.label22, 2, 0);
            this.tlpFixAttributesValues.Controls.Add(this.label23, 3, 0);
            this.tlpFixAttributesValues.Controls.Add(this.label24, 4, 0);
            this.tlpFixAttributesValues.Controls.Add(this.label25, 5, 0);
            this.tlpFixAttributesValues.Controls.Add(this.label26, 6, 0);
            this.tlpFixAttributesValues.Controls.Add(this.lblSpeedPoints, 0, 1);
            this.tlpFixAttributesValues.Controls.Add(this.lblPrecisionPoints, 0, 2);
            this.tlpFixAttributesValues.Controls.Add(this.lblEvasionPoints, 0, 3);
            this.tlpFixAttributesValues.Controls.Add(this.lblFocusPoints, 0, 4);
            this.tlpFixAttributesValues.Controls.Add(this.lblTrancePoints, 0, 5);
            this.tlpFixAttributesValues.Controls.Add(this.lblConcentrationPoints, 0, 6);
            this.tlpFixAttributesValues.Controls.Add(this.lblVigorPoints, 0, 7);
            this.tlpFixAttributesValues.Controls.Add(this.lblSConcentrationsPoints, 0, 8);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBaseVELValue, 1, 1);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBasePREValue, 1, 2);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBaseEVAValue, 1, 3);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBaseFOCValue, 1, 4);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBaseTRAValue, 1, 5);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBaseCOMValue, 1, 6);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBaseVIGValue, 1, 7);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedVELValue, 2, 1);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedPREValue, 2, 2);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedEVAValue, 2, 3);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBasePCValue, 1, 8);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedFOCValue, 2, 4);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedTRAValue, 2, 5);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedCOMValue, 2, 6);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedVIGValue, 2, 7);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesBreedPCValue, 2, 8);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassVELValue, 3, 1);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassPREValue, 3, 2);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassEVAValue, 3, 3);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassFOCValue, 3, 4);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassTRAValue, 3, 5);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassCOMValue, 3, 6);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassVIGValue, 3, 7);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesClassPCValue, 3, 8);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipeVELValue, 4, 1);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipePREValue, 4, 2);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipeEVAValue, 4, 3);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipeFOCValue, 4, 4);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipeTRAValue, 4, 5);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipeCOMValue, 4, 6);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesEquipeVIGValue, 4, 7);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelVELValue, 5, 1);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelPREValue, 5, 2);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelEVAValue, 5, 3);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelFOCValue, 5, 4);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelTRAValue, 5, 5);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelCOMValue, 5, 6);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelVIGValue, 5, 7);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalLevelPCValue, 5, 8);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalPREValue, 6, 2);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalEVAValue, 6, 3);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalFOCValue, 6, 4);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalCOMValue, 6, 6);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalVIGValue, 6, 7);
            this.tlpFixAttributesValues.Controls.Add(this.txtFixAttributesTotalPCValue, 6, 8);
            this.tlpFixAttributesValues.Location = new System.Drawing.Point(12, 614);
            this.tlpFixAttributesValues.Name = "tlpFixAttributesValues";
            this.tlpFixAttributesValues.RowCount = 9;
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpFixAttributesValues.Size = new System.Drawing.Size(987, 303);
            this.tlpFixAttributesValues.TabIndex = 7;
            // 
            // txtFixAttributesTotalTRAValue
            // 
            this.txtFixAttributesTotalTRAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalTRAValue.Location = new System.Drawing.Point(884, 169);
            this.txtFixAttributesTotalTRAValue.Name = "txtFixAttributesTotalTRAValue";
            this.txtFixAttributesTotalTRAValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalTRAValue.TabIndex = 23;
            // 
            // txtFixAttributesTotalVELValue
            // 
            this.txtFixAttributesTotalVELValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalVELValue.Location = new System.Drawing.Point(884, 37);
            this.txtFixAttributesTotalVELValue.Name = "txtFixAttributesTotalVELValue";
            this.txtFixAttributesTotalVELValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalVELValue.TabIndex = 23;
            // 
            // txtFixAttributesEquipePCValue
            // 
            this.txtFixAttributesEquipePCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipePCValue.Location = new System.Drawing.Point(590, 268);
            this.txtFixAttributesEquipePCValue.Name = "txtFixAttributesEquipePCValue";
            this.txtFixAttributesEquipePCValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipePCValue.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(242, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Base";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(358, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Raça";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(488, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "Classe";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(632, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "Equipe";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(753, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 20);
            this.label25.TabIndex = 4;
            this.label25.Text = "Total por Nível";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(912, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 20);
            this.label26.TabIndex = 5;
            this.label26.Text = "Total";
            // 
            // lblSpeedPoints
            // 
            this.lblSpeedPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpeedPoints.AutoSize = true;
            this.lblSpeedPoints.Location = new System.Drawing.Point(4, 40);
            this.lblSpeedPoints.Name = "lblSpeedPoints";
            this.lblSpeedPoints.Size = new System.Drawing.Size(121, 20);
            this.lblSpeedPoints.TabIndex = 6;
            this.lblSpeedPoints.Text = "Velocidade (VEL)";
            // 
            // lblPrecisionPoints
            // 
            this.lblPrecisionPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecisionPoints.AutoSize = true;
            this.lblPrecisionPoints.Location = new System.Drawing.Point(4, 73);
            this.lblPrecisionPoints.Name = "lblPrecisionPoints";
            this.lblPrecisionPoints.Size = new System.Drawing.Size(103, 20);
            this.lblPrecisionPoints.TabIndex = 7;
            this.lblPrecisionPoints.Text = "Precisão (PRE)";
            // 
            // lblEvasionPoints
            // 
            this.lblEvasionPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEvasionPoints.AutoSize = true;
            this.lblEvasionPoints.Location = new System.Drawing.Point(4, 106);
            this.lblEvasionPoints.Name = "lblEvasionPoints";
            this.lblEvasionPoints.Size = new System.Drawing.Size(95, 20);
            this.lblEvasionPoints.TabIndex = 8;
            this.lblEvasionPoints.Text = "Evasão (EVA)";
            // 
            // lblFocusPoints
            // 
            this.lblFocusPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFocusPoints.AutoSize = true;
            this.lblFocusPoints.Location = new System.Drawing.Point(4, 139);
            this.lblFocusPoints.Name = "lblFocusPoints";
            this.lblFocusPoints.Size = new System.Drawing.Size(82, 20);
            this.lblFocusPoints.TabIndex = 9;
            this.lblFocusPoints.Text = "Foco (FOC)";
            // 
            // lblTrancePoints
            // 
            this.lblTrancePoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTrancePoints.AutoSize = true;
            this.lblTrancePoints.Location = new System.Drawing.Point(4, 172);
            this.lblTrancePoints.Name = "lblTrancePoints";
            this.lblTrancePoints.Size = new System.Drawing.Size(92, 20);
            this.lblTrancePoints.TabIndex = 10;
            this.lblTrancePoints.Text = "Transe (TRA)";
            // 
            // lblConcentrationPoints
            // 
            this.lblConcentrationPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConcentrationPoints.AutoSize = true;
            this.lblConcentrationPoints.Location = new System.Drawing.Point(4, 205);
            this.lblConcentrationPoints.Name = "lblConcentrationPoints";
            this.lblConcentrationPoints.Size = new System.Drawing.Size(147, 20);
            this.lblConcentrationPoints.TabIndex = 11;
            this.lblConcentrationPoints.Text = "Concentração (COM)";
            // 
            // lblVigorPoints
            // 
            this.lblVigorPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVigorPoints.AutoSize = true;
            this.lblVigorPoints.Location = new System.Drawing.Point(4, 238);
            this.lblVigorPoints.Name = "lblVigorPoints";
            this.lblVigorPoints.Size = new System.Drawing.Size(82, 20);
            this.lblVigorPoints.TabIndex = 12;
            this.lblVigorPoints.Text = "Vigor (VIG)";
            // 
            // lblSConcentrationsPoints
            // 
            this.lblSConcentrationsPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSConcentrationsPoints.AutoSize = true;
            this.lblSConcentrationsPoints.Location = new System.Drawing.Point(4, 273);
            this.lblSConcentrationsPoints.Name = "lblSConcentrationsPoints";
            this.lblSConcentrationsPoints.Size = new System.Drawing.Size(200, 20);
            this.lblSConcentrationsPoints.TabIndex = 13;
            this.lblSConcentrationsPoints.Text = "Pontos de Concentração (PC)";
            // 
            // txtFixAttributesBaseVELValue
            // 
            this.txtFixAttributesBaseVELValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBaseVELValue.Location = new System.Drawing.Point(211, 37);
            this.txtFixAttributesBaseVELValue.Name = "txtFixAttributesBaseVELValue";
            this.txtFixAttributesBaseVELValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBaseVELValue.TabIndex = 14;
            // 
            // txtFixAttributesBasePREValue
            // 
            this.txtFixAttributesBasePREValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBasePREValue.Location = new System.Drawing.Point(211, 70);
            this.txtFixAttributesBasePREValue.Name = "txtFixAttributesBasePREValue";
            this.txtFixAttributesBasePREValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBasePREValue.TabIndex = 15;
            // 
            // txtFixAttributesBaseEVAValue
            // 
            this.txtFixAttributesBaseEVAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBaseEVAValue.Location = new System.Drawing.Point(211, 103);
            this.txtFixAttributesBaseEVAValue.Name = "txtFixAttributesBaseEVAValue";
            this.txtFixAttributesBaseEVAValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBaseEVAValue.TabIndex = 16;
            // 
            // txtFixAttributesBaseFOCValue
            // 
            this.txtFixAttributesBaseFOCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBaseFOCValue.Location = new System.Drawing.Point(211, 136);
            this.txtFixAttributesBaseFOCValue.Name = "txtFixAttributesBaseFOCValue";
            this.txtFixAttributesBaseFOCValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBaseFOCValue.TabIndex = 17;
            // 
            // txtFixAttributesBaseTRAValue
            // 
            this.txtFixAttributesBaseTRAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBaseTRAValue.Location = new System.Drawing.Point(211, 169);
            this.txtFixAttributesBaseTRAValue.Name = "txtFixAttributesBaseTRAValue";
            this.txtFixAttributesBaseTRAValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBaseTRAValue.TabIndex = 18;
            // 
            // txtFixAttributesBaseCOMValue
            // 
            this.txtFixAttributesBaseCOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBaseCOMValue.Location = new System.Drawing.Point(211, 202);
            this.txtFixAttributesBaseCOMValue.Name = "txtFixAttributesBaseCOMValue";
            this.txtFixAttributesBaseCOMValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBaseCOMValue.TabIndex = 19;
            // 
            // txtFixAttributesBaseVIGValue
            // 
            this.txtFixAttributesBaseVIGValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBaseVIGValue.Location = new System.Drawing.Point(211, 235);
            this.txtFixAttributesBaseVIGValue.Name = "txtFixAttributesBaseVIGValue";
            this.txtFixAttributesBaseVIGValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBaseVIGValue.TabIndex = 20;
            // 
            // txtFixAttributesBreedVELValue
            // 
            this.txtFixAttributesBreedVELValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedVELValue.Location = new System.Drawing.Point(321, 37);
            this.txtFixAttributesBreedVELValue.Name = "txtFixAttributesBreedVELValue";
            this.txtFixAttributesBreedVELValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedVELValue.TabIndex = 22;
            // 
            // txtFixAttributesBreedPREValue
            // 
            this.txtFixAttributesBreedPREValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedPREValue.Location = new System.Drawing.Point(321, 70);
            this.txtFixAttributesBreedPREValue.Name = "txtFixAttributesBreedPREValue";
            this.txtFixAttributesBreedPREValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedPREValue.TabIndex = 23;
            // 
            // txtFixAttributesBreedEVAValue
            // 
            this.txtFixAttributesBreedEVAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedEVAValue.Location = new System.Drawing.Point(321, 103);
            this.txtFixAttributesBreedEVAValue.Name = "txtFixAttributesBreedEVAValue";
            this.txtFixAttributesBreedEVAValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedEVAValue.TabIndex = 24;
            // 
            // txtFixAttributesBasePCValue
            // 
            this.txtFixAttributesBasePCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBasePCValue.Location = new System.Drawing.Point(211, 268);
            this.txtFixAttributesBasePCValue.Name = "txtFixAttributesBasePCValue";
            this.txtFixAttributesBasePCValue.Size = new System.Drawing.Size(103, 27);
            this.txtFixAttributesBasePCValue.TabIndex = 25;
            // 
            // txtFixAttributesBreedFOCValue
            // 
            this.txtFixAttributesBreedFOCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedFOCValue.Location = new System.Drawing.Point(321, 136);
            this.txtFixAttributesBreedFOCValue.Name = "txtFixAttributesBreedFOCValue";
            this.txtFixAttributesBreedFOCValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedFOCValue.TabIndex = 21;
            // 
            // txtFixAttributesBreedTRAValue
            // 
            this.txtFixAttributesBreedTRAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedTRAValue.Location = new System.Drawing.Point(321, 169);
            this.txtFixAttributesBreedTRAValue.Name = "txtFixAttributesBreedTRAValue";
            this.txtFixAttributesBreedTRAValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedTRAValue.TabIndex = 26;
            // 
            // txtFixAttributesBreedCOMValue
            // 
            this.txtFixAttributesBreedCOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedCOMValue.Location = new System.Drawing.Point(321, 202);
            this.txtFixAttributesBreedCOMValue.Name = "txtFixAttributesBreedCOMValue";
            this.txtFixAttributesBreedCOMValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedCOMValue.TabIndex = 27;
            // 
            // txtFixAttributesBreedVIGValue
            // 
            this.txtFixAttributesBreedVIGValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedVIGValue.Location = new System.Drawing.Point(321, 235);
            this.txtFixAttributesBreedVIGValue.Name = "txtFixAttributesBreedVIGValue";
            this.txtFixAttributesBreedVIGValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedVIGValue.TabIndex = 28;
            // 
            // txtFixAttributesBreedPCValue
            // 
            this.txtFixAttributesBreedPCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesBreedPCValue.Location = new System.Drawing.Point(321, 268);
            this.txtFixAttributesBreedPCValue.Name = "txtFixAttributesBreedPCValue";
            this.txtFixAttributesBreedPCValue.Size = new System.Drawing.Size(115, 27);
            this.txtFixAttributesBreedPCValue.TabIndex = 29;
            // 
            // txtFixAttributesClassVELValue
            // 
            this.txtFixAttributesClassVELValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassVELValue.Location = new System.Drawing.Point(443, 37);
            this.txtFixAttributesClassVELValue.Name = "txtFixAttributesClassVELValue";
            this.txtFixAttributesClassVELValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassVELValue.TabIndex = 30;
            // 
            // txtFixAttributesClassPREValue
            // 
            this.txtFixAttributesClassPREValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassPREValue.Location = new System.Drawing.Point(443, 70);
            this.txtFixAttributesClassPREValue.Name = "txtFixAttributesClassPREValue";
            this.txtFixAttributesClassPREValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassPREValue.TabIndex = 31;
            // 
            // txtFixAttributesClassEVAValue
            // 
            this.txtFixAttributesClassEVAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassEVAValue.Location = new System.Drawing.Point(443, 103);
            this.txtFixAttributesClassEVAValue.Name = "txtFixAttributesClassEVAValue";
            this.txtFixAttributesClassEVAValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassEVAValue.TabIndex = 32;
            // 
            // txtFixAttributesClassFOCValue
            // 
            this.txtFixAttributesClassFOCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassFOCValue.Location = new System.Drawing.Point(443, 136);
            this.txtFixAttributesClassFOCValue.Name = "txtFixAttributesClassFOCValue";
            this.txtFixAttributesClassFOCValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassFOCValue.TabIndex = 33;
            // 
            // txtFixAttributesClassTRAValue
            // 
            this.txtFixAttributesClassTRAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassTRAValue.Location = new System.Drawing.Point(443, 169);
            this.txtFixAttributesClassTRAValue.Name = "txtFixAttributesClassTRAValue";
            this.txtFixAttributesClassTRAValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassTRAValue.TabIndex = 34;
            // 
            // txtFixAttributesClassCOMValue
            // 
            this.txtFixAttributesClassCOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassCOMValue.Location = new System.Drawing.Point(443, 202);
            this.txtFixAttributesClassCOMValue.Name = "txtFixAttributesClassCOMValue";
            this.txtFixAttributesClassCOMValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassCOMValue.TabIndex = 35;
            // 
            // txtFixAttributesClassVIGValue
            // 
            this.txtFixAttributesClassVIGValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassVIGValue.Location = new System.Drawing.Point(443, 235);
            this.txtFixAttributesClassVIGValue.Name = "txtFixAttributesClassVIGValue";
            this.txtFixAttributesClassVIGValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassVIGValue.TabIndex = 36;
            // 
            // txtFixAttributesClassPCValue
            // 
            this.txtFixAttributesClassPCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesClassPCValue.Location = new System.Drawing.Point(443, 268);
            this.txtFixAttributesClassPCValue.Name = "txtFixAttributesClassPCValue";
            this.txtFixAttributesClassPCValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesClassPCValue.TabIndex = 37;
            // 
            // txtFixAttributesEquipeVELValue
            // 
            this.txtFixAttributesEquipeVELValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipeVELValue.Location = new System.Drawing.Point(590, 37);
            this.txtFixAttributesEquipeVELValue.Name = "txtFixAttributesEquipeVELValue";
            this.txtFixAttributesEquipeVELValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipeVELValue.TabIndex = 38;
            // 
            // txtFixAttributesEquipePREValue
            // 
            this.txtFixAttributesEquipePREValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipePREValue.Location = new System.Drawing.Point(590, 70);
            this.txtFixAttributesEquipePREValue.Name = "txtFixAttributesEquipePREValue";
            this.txtFixAttributesEquipePREValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipePREValue.TabIndex = 39;
            // 
            // txtFixAttributesEquipeEVAValue
            // 
            this.txtFixAttributesEquipeEVAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipeEVAValue.Location = new System.Drawing.Point(590, 103);
            this.txtFixAttributesEquipeEVAValue.Name = "txtFixAttributesEquipeEVAValue";
            this.txtFixAttributesEquipeEVAValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipeEVAValue.TabIndex = 40;
            // 
            // txtFixAttributesEquipeFOCValue
            // 
            this.txtFixAttributesEquipeFOCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipeFOCValue.Location = new System.Drawing.Point(590, 136);
            this.txtFixAttributesEquipeFOCValue.Name = "txtFixAttributesEquipeFOCValue";
            this.txtFixAttributesEquipeFOCValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipeFOCValue.TabIndex = 41;
            // 
            // txtFixAttributesEquipeTRAValue
            // 
            this.txtFixAttributesEquipeTRAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipeTRAValue.Location = new System.Drawing.Point(590, 169);
            this.txtFixAttributesEquipeTRAValue.Name = "txtFixAttributesEquipeTRAValue";
            this.txtFixAttributesEquipeTRAValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipeTRAValue.TabIndex = 42;
            // 
            // txtFixAttributesEquipeCOMValue
            // 
            this.txtFixAttributesEquipeCOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipeCOMValue.Location = new System.Drawing.Point(590, 202);
            this.txtFixAttributesEquipeCOMValue.Name = "txtFixAttributesEquipeCOMValue";
            this.txtFixAttributesEquipeCOMValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipeCOMValue.TabIndex = 43;
            // 
            // txtFixAttributesEquipeVIGValue
            // 
            this.txtFixAttributesEquipeVIGValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesEquipeVIGValue.Location = new System.Drawing.Point(590, 235);
            this.txtFixAttributesEquipeVIGValue.Name = "txtFixAttributesEquipeVIGValue";
            this.txtFixAttributesEquipeVIGValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesEquipeVIGValue.TabIndex = 44;
            // 
            // txtFixAttributesTotalLevelVELValue
            // 
            this.txtFixAttributesTotalLevelVELValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelVELValue.Location = new System.Drawing.Point(737, 37);
            this.txtFixAttributesTotalLevelVELValue.Name = "txtFixAttributesTotalLevelVELValue";
            this.txtFixAttributesTotalLevelVELValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelVELValue.TabIndex = 46;
            // 
            // txtFixAttributesTotalLevelPREValue
            // 
            this.txtFixAttributesTotalLevelPREValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelPREValue.Location = new System.Drawing.Point(737, 70);
            this.txtFixAttributesTotalLevelPREValue.Name = "txtFixAttributesTotalLevelPREValue";
            this.txtFixAttributesTotalLevelPREValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelPREValue.TabIndex = 47;
            // 
            // txtFixAttributesTotalLevelEVAValue
            // 
            this.txtFixAttributesTotalLevelEVAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelEVAValue.Location = new System.Drawing.Point(737, 103);
            this.txtFixAttributesTotalLevelEVAValue.Name = "txtFixAttributesTotalLevelEVAValue";
            this.txtFixAttributesTotalLevelEVAValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelEVAValue.TabIndex = 48;
            // 
            // txtFixAttributesTotalLevelFOCValue
            // 
            this.txtFixAttributesTotalLevelFOCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelFOCValue.Location = new System.Drawing.Point(737, 136);
            this.txtFixAttributesTotalLevelFOCValue.Name = "txtFixAttributesTotalLevelFOCValue";
            this.txtFixAttributesTotalLevelFOCValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelFOCValue.TabIndex = 49;
            // 
            // txtFixAttributesTotalLevelTRAValue
            // 
            this.txtFixAttributesTotalLevelTRAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelTRAValue.Location = new System.Drawing.Point(737, 169);
            this.txtFixAttributesTotalLevelTRAValue.Name = "txtFixAttributesTotalLevelTRAValue";
            this.txtFixAttributesTotalLevelTRAValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelTRAValue.TabIndex = 50;
            // 
            // txtFixAttributesTotalLevelCOMValue
            // 
            this.txtFixAttributesTotalLevelCOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelCOMValue.Location = new System.Drawing.Point(737, 202);
            this.txtFixAttributesTotalLevelCOMValue.Name = "txtFixAttributesTotalLevelCOMValue";
            this.txtFixAttributesTotalLevelCOMValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelCOMValue.TabIndex = 51;
            // 
            // txtFixAttributesTotalLevelVIGValue
            // 
            this.txtFixAttributesTotalLevelVIGValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelVIGValue.Location = new System.Drawing.Point(737, 235);
            this.txtFixAttributesTotalLevelVIGValue.Name = "txtFixAttributesTotalLevelVIGValue";
            this.txtFixAttributesTotalLevelVIGValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelVIGValue.TabIndex = 52;
            // 
            // txtFixAttributesTotalLevelPCValue
            // 
            this.txtFixAttributesTotalLevelPCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalLevelPCValue.Location = new System.Drawing.Point(737, 268);
            this.txtFixAttributesTotalLevelPCValue.Name = "txtFixAttributesTotalLevelPCValue";
            this.txtFixAttributesTotalLevelPCValue.Size = new System.Drawing.Size(140, 27);
            this.txtFixAttributesTotalLevelPCValue.TabIndex = 53;
            // 
            // txtFixAttributesTotalPREValue
            // 
            this.txtFixAttributesTotalPREValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalPREValue.Location = new System.Drawing.Point(884, 70);
            this.txtFixAttributesTotalPREValue.Name = "txtFixAttributesTotalPREValue";
            this.txtFixAttributesTotalPREValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalPREValue.TabIndex = 54;
            // 
            // txtFixAttributesTotalEVAValue
            // 
            this.txtFixAttributesTotalEVAValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalEVAValue.Location = new System.Drawing.Point(884, 103);
            this.txtFixAttributesTotalEVAValue.Name = "txtFixAttributesTotalEVAValue";
            this.txtFixAttributesTotalEVAValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalEVAValue.TabIndex = 55;
            // 
            // txtFixAttributesTotalFOCValue
            // 
            this.txtFixAttributesTotalFOCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalFOCValue.Location = new System.Drawing.Point(884, 136);
            this.txtFixAttributesTotalFOCValue.Name = "txtFixAttributesTotalFOCValue";
            this.txtFixAttributesTotalFOCValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalFOCValue.TabIndex = 56;
            // 
            // txtFixAttributesTotalCOMValue
            // 
            this.txtFixAttributesTotalCOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalCOMValue.Location = new System.Drawing.Point(884, 202);
            this.txtFixAttributesTotalCOMValue.Name = "txtFixAttributesTotalCOMValue";
            this.txtFixAttributesTotalCOMValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalCOMValue.TabIndex = 57;
            // 
            // txtFixAttributesTotalVIGValue
            // 
            this.txtFixAttributesTotalVIGValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalVIGValue.Location = new System.Drawing.Point(884, 235);
            this.txtFixAttributesTotalVIGValue.Name = "txtFixAttributesTotalVIGValue";
            this.txtFixAttributesTotalVIGValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalVIGValue.TabIndex = 58;
            // 
            // txtFixAttributesTotalPCValue
            // 
            this.txtFixAttributesTotalPCValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixAttributesTotalPCValue.Location = new System.Drawing.Point(884, 268);
            this.txtFixAttributesTotalPCValue.Name = "txtFixAttributesTotalPCValue";
            this.txtFixAttributesTotalPCValue.Size = new System.Drawing.Size(99, 27);
            this.txtFixAttributesTotalPCValue.TabIndex = 59;
            // 
            // MainScreen
            // 
            this.ClientSize = new System.Drawing.Size(1011, 1055);
            this.Controls.Add(this.tlpFixAttributesValues);
            this.Controls.Add(this.tlpFixAttributesHeader);
            this.Controls.Add(this.tlpMutableAttributesValues);
            this.Controls.Add(this.tlpMutableAttributesHeader);
            this.Controls.Add(this.tlpCharct);
            this.Controls.Add(this.LayoutHeader);
            this.Name = "MainScreen";
            this.LayoutHeader.ResumeLayout(false);
            this.LayoutHeader.PerformLayout();
            this.tlpCharct.ResumeLayout(false);
            this.tlpCharct.PerformLayout();
            this.tlpMutableAttributesHeader.ResumeLayout(false);
            this.tlpMutableAttributesHeader.PerformLayout();
            this.tlpMutableAttributesValues.ResumeLayout(false);
            this.tlpMutableAttributesValues.PerformLayout();
            this.tlpFixAttributesHeader.ResumeLayout(false);
            this.tlpFixAttributesHeader.PerformLayout();
            this.tlpFixAttributesValues.ResumeLayout(false);
            this.tlpFixAttributesValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel LayoutHeader;
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
        private TextBox txtMutableAttributesBasePVValue;
        private TextBox txtMutableAttributesBasePMValue;
        private TextBox txtMutableAttributesBaseDAFValue;
        private TextBox txtMutableAttributesBaseDAMValue;
        private TextBox txtMutableAttributesBaseDEFValue;
        private TextBox txtMutableAttributesBaseDEMValue;
        private TextBox txtMutableAttributesBaseDDValue;
        private TextBox txtMutableAttributesBreedDAMValue;
        private TextBox txtMutableAttributesBreedPVValue;
        private TextBox txtMutableAttributesBreedPMValue;
        private TextBox txtMutableAttributesBreedDAFValue;
        private TextBox textBox4;
        private TextBox txtMutableAttributesBreedDEFValue;
        private TextBox txtMutableAttributesBreedDEMValue;
        private TextBox txtMutableAttributesBreedDDValue;
        private TextBox txtMutableAttributesBreedRDValue;
        private TextBox txtMutableAttributesTotalDEFValue;
        private TextBox txtMutableAttributesTotalPVValue;
        private TextBox txtMutableAttributesEquipeRDValue;
        private TextBox txtMutableAttributesClassPVValue;
        private TextBox txtMutableAttributesClassPMValue;
        private TextBox txtMutableAttributesClassDAFValue;
        private TextBox txtMutableAttributesClassDAMValue;
        private TextBox txtMutableAttributesClassDEFValue;
        private TextBox txtMutableAttributesClassDEMValue;
        private TextBox txtMutableAttributesClassDDValue;
        private TextBox txtMutableAttributesClassRDValue;
        private TextBox txtMutableAttributesEquipePVValue;
        private TextBox txtMutableAttributesEquipePMValue;
        private TextBox txtMutableAttributesEquipeDAFValue;
        private TextBox txtMutableAttributesEquipeDAMValue;
        private TextBox txtMutableAttributesEquipeDEFValue;
        private TextBox txtMutableAttributesEquipeDEMValue;
        private TextBox txtMutableAttributesEquipeDDValue;
        private TextBox txtMutableAttributesTotalLevelPVValue;
        private TextBox txtMutableAttributesTotalLevelPMValue;
        private TextBox txtMutableAttributesTotalLevelDAFValue;
        private TextBox txtMutableAttributesTotalLevelDAMValue;
        private TextBox txtMutableAttributesTotalLevelDEFValue;
        private TextBox txtMutableAttributesTotalLevelDEMValue;
        private TextBox txtMutableAttributesTotalLevelDDValue;
        private TextBox txtMutableAttributesTotalLevelRDValue;
        private TextBox txtMutableAttributesTotalPMValue;
        private TextBox txtMutableAttributesTotalDAFValue;
        private TextBox txtMutableAttributesTotalDAMValue;
        private TextBox txtMutableAttributesTotalDEMValue;
        private TextBox txtMutableAttributesTotalDDValue;
        private TextBox txtMutableAttributesTotalRDValue;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private TextBox textBox29;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox32;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox35;
        private TextBox textBox36;
        private TextBox textBox37;
        private TextBox textBox38;
        private TextBox textBox39;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox42;
        private TextBox textBox43;
        private TextBox textBox44;
        private TextBox textBox45;
        private TextBox textBox46;
        private TextBox textBox47;
        private TextBox textBox48;
        private Label label17;
        private TextBox textBox49;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblFixAttributesHeader;
        private TableLayoutPanel tlpFixAttributesHeader;
        private TableLayoutPanel tlpFixAttributesValues;
        private TextBox txtFixAttributesTotalTRAValue;
        private TextBox txtFixAttributesTotalVELValue;
        private TextBox txtFixAttributesEquipePCValue;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label lblSpeedPoints;
        private Label lblPrecisionPoints;
        private Label lblEvasionPoints;
        private Label lblFocusPoints;
        private Label lblTrancePoints;
        private Label lblConcentrationPoints;
        private Label lblVigorPoints;
        private Label lblSConcentrationsPoints;
        private TextBox txtFixAttributesBaseVELValue;
        private TextBox txtFixAttributesBasePREValue;
        private TextBox txtFixAttributesBaseEVAValue;
        private TextBox txtFixAttributesBaseFOCValue;
        private TextBox txtFixAttributesBaseTRAValue;
        private TextBox txtFixAttributesBaseCOMValue;
        private TextBox txtFixAttributesBaseVIGValue;
        private TextBox txtFixAttributesBreedVELValue;
        private TextBox txtFixAttributesBreedPREValue;
        private TextBox txtFixAttributesBreedEVAValue;
        private TextBox txtFixAttributesBasePCValue;
        private TextBox txtFixAttributesBreedFOCValue;
        private TextBox txtFixAttributesBreedTRAValue;
        private TextBox txtFixAttributesBreedCOMValue;
        private TextBox txtFixAttributesBreedVIGValue;
        private TextBox txtFixAttributesBreedPCValue;
        private TextBox txtFixAttributesClassVELValue;
        private TextBox txtFixAttributesClassPREValue;
        private TextBox txtFixAttributesClassEVAValue;
        private TextBox txtFixAttributesClassFOCValue;
        private TextBox txtFixAttributesClassTRAValue;
        private TextBox txtFixAttributesClassCOMValue;
        private TextBox txtFixAttributesClassVIGValue;
        private TextBox txtFixAttributesClassPCValue;
        private TextBox txtFixAttributesEquipeVELValue;
        private TextBox txtFixAttributesEquipePREValue;
        private TextBox txtFixAttributesEquipeEVAValue;
        private TextBox txtFixAttributesEquipeFOCValue;
        private TextBox txtFixAttributesEquipeTRAValue;
        private TextBox txtFixAttributesEquipeCOMValue;
        private TextBox txtFixAttributesEquipeVIGValue;
        private TextBox txtFixAttributesTotalLevelVELValue;
        private TextBox txtFixAttributesTotalLevelPREValue;
        private TextBox txtFixAttributesTotalLevelEVAValue;
        private TextBox txtFixAttributesTotalLevelFOCValue;
        private TextBox txtFixAttributesTotalLevelTRAValue;
        private TextBox txtFixAttributesTotalLevelCOMValue;
        private TextBox txtFixAttributesTotalLevelVIGValue;
        private TextBox txtFixAttributesTotalLevelPCValue;
        private TextBox txtFixAttributesTotalPREValue;
        private TextBox txtFixAttributesTotalEVAValue;
        private TextBox txtFixAttributesTotalFOCValue;
        private TextBox txtFixAttributesTotalCOMValue;
        private TextBox txtFixAttributesTotalVIGValue;
        private TextBox txtFixAttributesTotalPCValue;
    }
}