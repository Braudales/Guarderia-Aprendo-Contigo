namespace Win.GAP
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label direccionMLabel;
            System.Windows.Forms.Label direccionPLabel;
            System.Windows.Forms.Label identidadMLabel;
            System.Windows.Forms.Label identidadPLabel;
            System.Windows.Forms.Label nombredelamadreLabel;
            System.Windows.Forms.Label nombredelninoLabel;
            System.Windows.Forms.Label nombredelpadreLabel;
            System.Windows.Forms.Label ocupacionMLabel;
            System.Windows.Forms.Label ocupacionPLabel;
            System.Windows.Forms.Label telefonoMLabel;
            System.Windows.Forms.Label telefonoPLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.direccionMTextBox = new System.Windows.Forms.TextBox();
            this.direccionPTextBox = new System.Windows.Forms.TextBox();
            this.identidadMTextBox = new System.Windows.Forms.TextBox();
            this.nombredelamadreTextBox = new System.Windows.Forms.TextBox();
            this.nombredelninoTextBox = new System.Windows.Forms.TextBox();
            this.nombredelpadreTextBox = new System.Windows.Forms.TextBox();
            this.ocupacionMTextBox = new System.Windows.Forms.TextBox();
            this.ocupacionPTextBox = new System.Windows.Forms.TextBox();
            this.telefonoMTextBox = new System.Windows.Forms.TextBox();
            this.telefonoPTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.identidadPTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaingresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            activoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            direccionMLabel = new System.Windows.Forms.Label();
            direccionPLabel = new System.Windows.Forms.Label();
            identidadMLabel = new System.Windows.Forms.Label();
            identidadPLabel = new System.Windows.Forms.Label();
            nombredelamadreLabel = new System.Windows.Forms.Label();
            nombredelninoLabel = new System.Windows.Forms.Label();
            nombredelpadreLabel = new System.Windows.Forms.Label();
            ocupacionMLabel = new System.Windows.Forms.Label();
            ocupacionPLabel = new System.Windows.Forms.Label();
            telefonoMLabel = new System.Windows.Forms.Label();
            telefonoPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(496, 52);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(54, 16);
            activoLabel.TabIndex = 2;
            activoLabel.Text = "activo:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(59, 55);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(21, 16);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Id";
            // 
            // direccionMLabel
            // 
            direccionMLabel.AutoSize = true;
            direccionMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionMLabel.Location = new System.Drawing.Point(16, 25);
            direccionMLabel.Name = "direccionMLabel";
            direccionMLabel.Size = new System.Drawing.Size(130, 16);
            direccionMLabel.TabIndex = 6;
            direccionMLabel.Text = "Direccion Madre :";
            // 
            // direccionPLabel
            // 
            direccionPLabel.AutoSize = true;
            direccionPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionPLabel.Location = new System.Drawing.Point(6, 25);
            direccionPLabel.Name = "direccionPLabel";
            direccionPLabel.Size = new System.Drawing.Size(128, 16);
            direccionPLabel.TabIndex = 8;
            direccionPLabel.Text = "Direccion Padre :";
            // 
            // identidadMLabel
            // 
            identidadMLabel.AutoSize = true;
            identidadMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identidadMLabel.Location = new System.Drawing.Point(17, 56);
            identidadMLabel.Name = "identidadMLabel";
            identidadMLabel.Size = new System.Drawing.Size(129, 16);
            identidadMLabel.TabIndex = 10;
            identidadMLabel.Text = "Identidad Madre :";
            // 
            // identidadPLabel
            // 
            identidadPLabel.AutoSize = true;
            identidadPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            identidadPLabel.Location = new System.Drawing.Point(7, 56);
            identidadPLabel.Name = "identidadPLabel";
            identidadPLabel.Size = new System.Drawing.Size(127, 16);
            identidadPLabel.TabIndex = 12;
            identidadPLabel.Text = "Identidad Padre :";
            // 
            // nombredelamadreLabel
            // 
            nombredelamadreLabel.AutoSize = true;
            nombredelamadreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombredelamadreLabel.Location = new System.Drawing.Point(17, 90);
            nombredelamadreLabel.Name = "nombredelamadreLabel";
            nombredelamadreLabel.Size = new System.Drawing.Size(141, 16);
            nombredelamadreLabel.TabIndex = 14;
            nombredelamadreLabel.Text = "Nombre de Madre :";
            // 
            // nombredelninoLabel
            // 
            nombredelninoLabel.AutoSize = true;
            nombredelninoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombredelninoLabel.Location = new System.Drawing.Point(59, 81);
            nombredelninoLabel.Name = "nombredelninoLabel";
            nombredelninoLabel.Size = new System.Drawing.Size(148, 16);
            nombredelninoLabel.TabIndex = 16;
            nombredelninoLabel.Text = "Nombre del Niño(a):";
            // 
            // nombredelpadreLabel
            // 
            nombredelpadreLabel.AutoSize = true;
            nombredelpadreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombredelpadreLabel.Location = new System.Drawing.Point(7, 92);
            nombredelpadreLabel.Name = "nombredelpadreLabel";
            nombredelpadreLabel.Size = new System.Drawing.Size(138, 16);
            nombredelpadreLabel.TabIndex = 18;
            nombredelpadreLabel.Text = "Nombre del padre:";
            // 
            // ocupacionMLabel
            // 
            ocupacionMLabel.AutoSize = true;
            ocupacionMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ocupacionMLabel.Location = new System.Drawing.Point(16, 123);
            ocupacionMLabel.Name = "ocupacionMLabel";
            ocupacionMLabel.Size = new System.Drawing.Size(138, 16);
            ocupacionMLabel.TabIndex = 20;
            ocupacionMLabel.Text = "Ocupacion Madre :";
            // 
            // ocupacionPLabel
            // 
            ocupacionPLabel.AutoSize = true;
            ocupacionPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ocupacionPLabel.Location = new System.Drawing.Point(10, 129);
            ocupacionPLabel.Name = "ocupacionPLabel";
            ocupacionPLabel.Size = new System.Drawing.Size(136, 16);
            ocupacionPLabel.TabIndex = 22;
            ocupacionPLabel.Text = "Ocupacion Padre :";
            // 
            // telefonoMLabel
            // 
            telefonoMLabel.AutoSize = true;
            telefonoMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoMLabel.Location = new System.Drawing.Point(16, 164);
            telefonoMLabel.Name = "telefonoMLabel";
            telefonoMLabel.Size = new System.Drawing.Size(126, 16);
            telefonoMLabel.TabIndex = 24;
            telefonoMLabel.Text = "Telefono Madre :";
            // 
            // telefonoPLabel
            // 
            telefonoPLabel.AutoSize = true;
            telefonoPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoPLabel.Location = new System.Drawing.Point(10, 166);
            telefonoPLabel.Name = "telefonoPLabel";
            telefonoPLabel.Size = new System.Drawing.Size(124, 16);
            telefonoPLabel.TabIndex = 26;
            telefonoPLabel.Text = "Telefono Padre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(59, 117);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 16);
            label1.TabIndex = 39;
            label1.Text = "Fecha de Ingreso";
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = null;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = null;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientesBindingNavigatorSaveItem,
            this.Cancelar});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(1095, 25);
            this.clientesBindingNavigator.TabIndex = 0;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(57, 22);
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientesBindingSource, "activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(556, 47);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(121, 24);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Id", true));
            this.Id.Location = new System.Drawing.Point(213, 52);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(249, 20);
            this.Id.TabIndex = 5;
            // 
            // direccionMTextBox
            // 
            this.direccionMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccionM", true));
            this.direccionMTextBox.Location = new System.Drawing.Point(163, 21);
            this.direccionMTextBox.Name = "direccionMTextBox";
            this.direccionMTextBox.Size = new System.Drawing.Size(269, 20);
            this.direccionMTextBox.TabIndex = 7;
            // 
            // direccionPTextBox
            // 
            this.direccionPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccionP", true));
            this.direccionPTextBox.Location = new System.Drawing.Point(150, 21);
            this.direccionPTextBox.Name = "direccionPTextBox";
            this.direccionPTextBox.Size = new System.Drawing.Size(306, 20);
            this.direccionPTextBox.TabIndex = 9;
            this.direccionPTextBox.TextChanged += new System.EventHandler(this.direccionPTextBox_TextChanged);
            // 
            // identidadMTextBox
            // 
            this.identidadMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "identidadM", true));
            this.identidadMTextBox.Location = new System.Drawing.Point(164, 52);
            this.identidadMTextBox.Name = "identidadMTextBox";
            this.identidadMTextBox.Size = new System.Drawing.Size(269, 20);
            this.identidadMTextBox.TabIndex = 11;
            // 
            // nombredelamadreTextBox
            // 
            this.nombredelamadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombredelamadre", true));
            this.nombredelamadreTextBox.Location = new System.Drawing.Point(164, 86);
            this.nombredelamadreTextBox.Name = "nombredelamadreTextBox";
            this.nombredelamadreTextBox.Size = new System.Drawing.Size(269, 20);
            this.nombredelamadreTextBox.TabIndex = 15;
            // 
            // nombredelninoTextBox
            // 
            this.nombredelninoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombredelnino", true));
            this.nombredelninoTextBox.Location = new System.Drawing.Point(213, 80);
            this.nombredelninoTextBox.Name = "nombredelninoTextBox";
            this.nombredelninoTextBox.Size = new System.Drawing.Size(249, 20);
            this.nombredelninoTextBox.TabIndex = 17;
            // 
            // nombredelpadreTextBox
            // 
            this.nombredelpadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombredelpadre", true));
            this.nombredelpadreTextBox.Location = new System.Drawing.Point(151, 90);
            this.nombredelpadreTextBox.Name = "nombredelpadreTextBox";
            this.nombredelpadreTextBox.Size = new System.Drawing.Size(306, 20);
            this.nombredelpadreTextBox.TabIndex = 19;
            this.nombredelpadreTextBox.TextChanged += new System.EventHandler(this.nombredelpadreTextBox_TextChanged);
            // 
            // ocupacionMTextBox
            // 
            this.ocupacionMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ocupacionM", true));
            this.ocupacionMTextBox.Location = new System.Drawing.Point(163, 119);
            this.ocupacionMTextBox.Name = "ocupacionMTextBox";
            this.ocupacionMTextBox.Size = new System.Drawing.Size(269, 20);
            this.ocupacionMTextBox.TabIndex = 21;
            // 
            // ocupacionPTextBox
            // 
            this.ocupacionPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "ocupacionP", true));
            this.ocupacionPTextBox.Location = new System.Drawing.Point(152, 125);
            this.ocupacionPTextBox.Name = "ocupacionPTextBox";
            this.ocupacionPTextBox.Size = new System.Drawing.Size(306, 20);
            this.ocupacionPTextBox.TabIndex = 23;
            this.ocupacionPTextBox.TextChanged += new System.EventHandler(this.ocupacionPTextBox_TextChanged);
            // 
            // telefonoMTextBox
            // 
            this.telefonoMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefonoM", true));
            this.telefonoMTextBox.Location = new System.Drawing.Point(163, 160);
            this.telefonoMTextBox.Name = "telefonoMTextBox";
            this.telefonoMTextBox.Size = new System.Drawing.Size(269, 20);
            this.telefonoMTextBox.TabIndex = 25;
            // 
            // telefonoPTextBox
            // 
            this.telefonoPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefonoP", true));
            this.telefonoPTextBox.Location = new System.Drawing.Point(151, 164);
            this.telefonoPTextBox.Name = "telefonoPTextBox";
            this.telefonoPTextBox.Size = new System.Drawing.Size(306, 20);
            this.telefonoPTextBox.TabIndex = 27;
            this.telefonoPTextBox.TextChanged += new System.EventHandler(this.telefonoPTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nombredelpadreLabel);
            this.groupBox1.Controls.Add(this.telefonoPTextBox);
            this.groupBox1.Controls.Add(telefonoPLabel);
            this.groupBox1.Controls.Add(this.ocupacionPTextBox);
            this.groupBox1.Controls.Add(ocupacionPLabel);
            this.groupBox1.Controls.Add(this.nombredelpadreTextBox);
            this.groupBox1.Controls.Add(this.identidadPTextBox);
            this.groupBox1.Controls.Add(identidadPLabel);
            this.groupBox1.Controls.Add(this.direccionPTextBox);
            this.groupBox1.Controls.Add(direccionPLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 227);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Padre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nombredelamadreLabel);
            this.groupBox2.Controls.Add(this.telefonoMTextBox);
            this.groupBox2.Controls.Add(telefonoMLabel);
            this.groupBox2.Controls.Add(this.ocupacionMTextBox);
            this.groupBox2.Controls.Add(ocupacionMLabel);
            this.groupBox2.Controls.Add(this.nombredelamadreTextBox);
            this.groupBox2.Controls.Add(this.identidadMTextBox);
            this.groupBox2.Controls.Add(identidadMLabel);
            this.groupBox2.Controls.Add(this.direccionMTextBox);
            this.groupBox2.Controls.Add(direccionMLabel);
            this.groupBox2.Location = new System.Drawing.Point(607, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 227);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Madre";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(701, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Agregar Fotos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(823, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 37;
            this.button6.Text = "Remover Fotos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg,png|*.jpg;*.png";
            // 
            // identidadPTextBox
            // 
            this.identidadPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "identidadP", true));
            this.identidadPTextBox.Location = new System.Drawing.Point(151, 52);
            this.identidadPTextBox.Name = "identidadPTextBox";
            this.identidadPTextBox.Size = new System.Drawing.Size(306, 20);
            this.identidadPTextBox.TabIndex = 13;
            this.identidadPTextBox.TextChanged += new System.EventHandler(this.identidadPTextBox_TextChanged);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(701, 55);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(207, 119);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 40;
            this.fotoPictureBox.TabStop = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(BL.GAP.Clientes);
            // 
            // fechaingresoDateTimePicker
            // 
            this.fechaingresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fechaingreso", true));
            this.fechaingresoDateTimePicker.Location = new System.Drawing.Point(213, 117);
            this.fechaingresoDateTimePicker.Name = "fechaingresoDateTimePicker";
            this.fechaingresoDateTimePicker.Size = new System.Drawing.Size(249, 20);
            this.fechaingresoDateTimePicker.TabIndex = 41;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 548);
            this.Controls.Add(this.fechaingresoDateTimePicker);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.Id);
            this.Controls.Add(nombredelninoLabel);
            this.Controls.Add(this.nombredelninoTextBox);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion de clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientesBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox direccionMTextBox;
        private System.Windows.Forms.TextBox direccionPTextBox;
        private System.Windows.Forms.TextBox identidadMTextBox;
        private System.Windows.Forms.TextBox nombredelamadreTextBox;
        private System.Windows.Forms.TextBox nombredelninoTextBox;
        private System.Windows.Forms.TextBox nombredelpadreTextBox;
        private System.Windows.Forms.TextBox ocupacionMTextBox;
        private System.Windows.Forms.TextBox ocupacionPTextBox;
        private System.Windows.Forms.TextBox telefonoMTextBox;
        private System.Windows.Forms.TextBox telefonoPTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripButton Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox identidadPTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.DateTimePicker fechaingresoDateTimePicker;
    }
}