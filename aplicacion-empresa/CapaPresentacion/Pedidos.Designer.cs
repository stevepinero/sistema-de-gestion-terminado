namespace CapaPresentacion
{
    partial class Pedidos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.labelPagina = new System.Windows.Forms.Label();
            this.labelMensajes = new System.Windows.Forms.Label();
            this.tabControlPedidos = new System.Windows.Forms.TabControl();
            this.tabPagePendientes = new System.Windows.Forms.TabPage();
            this.dataGridViewPedidosPendientes = new System.Windows.Forms.DataGridView();
            this.ver_pedidos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageEntregados = new System.Windows.Forms.TabPage();
            this.dataGridViewPedidosEntregados = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonMarcarEntregado = new System.Windows.Forms.Button();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxBuscarNombre = new System.Windows.Forms.TextBox();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelPaginacion.SuspendLayout();
            this.tabControlPedidos.SuspendLayout();
            this.tabPagePendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosPendientes)).BeginInit();
            this.tabPageEntregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosEntregados)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.tableLayoutPanelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.ColumnCount = 1;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelBottom, 0, 2);
            this.tableLayoutPanelGeneral.Controls.Add(this.tabControlPedidos, 0, 1);
            this.tableLayoutPanelGeneral.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 3;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(973, 353);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.52239F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47761F));
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanelPaginacion, 1, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.labelMensajes, 0, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(967, 38);
            this.tableLayoutPanelBottom.TabIndex = 4;
            // 
            // tableLayoutPanelPaginacion
            // 
            this.tableLayoutPanelPaginacion.ColumnCount = 3;
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPaginacion.Controls.Add(this.buttonSiguiente, 2, 0);
            this.tableLayoutPanelPaginacion.Controls.Add(this.buttonAnterior, 1, 0);
            this.tableLayoutPanelPaginacion.Controls.Add(this.labelPagina, 0, 0);
            this.tableLayoutPanelPaginacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPaginacion.Location = new System.Drawing.Point(539, 3);
            this.tableLayoutPanelPaginacion.Name = "tableLayoutPanelPaginacion";
            this.tableLayoutPanelPaginacion.RowCount = 1;
            this.tableLayoutPanelPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaginacion.Size = new System.Drawing.Size(425, 32);
            this.tableLayoutPanelPaginacion.TabIndex = 2;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSiguiente.BackColor = System.Drawing.Color.Orange;
            this.buttonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiguiente.Location = new System.Drawing.Point(328, 0);
            this.buttonSiguiente.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(97, 32);
            this.buttonSiguiente.TabIndex = 0;
            this.buttonSiguiente.Text = ">>";
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnterior.BackColor = System.Drawing.Color.Orange;
            this.buttonAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnterior.Location = new System.Drawing.Point(223, 0);
            this.buttonAnterior.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(95, 32);
            this.buttonAnterior.TabIndex = 1;
            this.buttonAnterior.Text = "<<";
            this.buttonAnterior.UseVisualStyleBackColor = false;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // labelPagina
            // 
            this.labelPagina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPagina.AutoSize = true;
            this.labelPagina.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagina.Location = new System.Drawing.Point(120, 6);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(100, 19);
            this.labelPagina.TabIndex = 2;
            this.labelPagina.Text = "Página X de X";
            // 
            // labelMensajes
            // 
            this.labelMensajes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMensajes.AutoSize = true;
            this.labelMensajes.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajes.Location = new System.Drawing.Point(3, 9);
            this.labelMensajes.Name = "labelMensajes";
            this.labelMensajes.Size = new System.Drawing.Size(445, 19);
            this.labelMensajes.TabIndex = 3;
            this.labelMensajes.Text = "Bienvenido al Sistema de Gestión. Este será su Área de Mensajes";
            this.labelMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPagePendientes);
            this.tabControlPedidos.Controls.Add(this.tabPageEntregados);
            this.tabControlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPedidos.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPedidos.Location = new System.Drawing.Point(13, 98);
            this.tabControlPedidos.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(957, 208);
            this.tabControlPedidos.TabIndex = 2;
            this.tabControlPedidos.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlPedidos_Selected);
            // 
            // tabPagePendientes
            // 
            this.tabPagePendientes.Controls.Add(this.dataGridViewPedidosPendientes);
            this.tabPagePendientes.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabPagePendientes.Location = new System.Drawing.Point(4, 35);
            this.tabPagePendientes.Name = "tabPagePendientes";
            this.tabPagePendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePendientes.Size = new System.Drawing.Size(949, 169);
            this.tabPagePendientes.TabIndex = 0;
            this.tabPagePendientes.Text = "PENDIENTES";
            this.tabPagePendientes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedidosPendientes
            // 
            this.dataGridViewPedidosPendientes.AllowUserToAddRows = false;
            this.dataGridViewPedidosPendientes.AllowUserToDeleteRows = false;
            this.dataGridViewPedidosPendientes.AllowUserToOrderColumns = true;
            this.dataGridViewPedidosPendientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPedidosPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedidosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPedidosPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPedidosPendientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPedidosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPedidosPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPedidosPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPedidosPendientes.ColumnHeadersHeight = 50;
            this.dataGridViewPedidosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPedidosPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ver_pedidos});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidosPendientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPedidosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidosPendientes.EnableHeadersVisualStyles = false;
            this.dataGridViewPedidosPendientes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPedidosPendientes.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dataGridViewPedidosPendientes.MultiSelect = false;
            this.dataGridViewPedidosPendientes.Name = "dataGridViewPedidosPendientes";
            this.dataGridViewPedidosPendientes.ReadOnly = true;
            this.dataGridViewPedidosPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPedidosPendientes.RowHeadersVisible = false;
            this.dataGridViewPedidosPendientes.RowTemplate.ReadOnly = true;
            this.dataGridViewPedidosPendientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidosPendientes.ShowCellErrors = false;
            this.dataGridViewPedidosPendientes.ShowCellToolTips = false;
            this.dataGridViewPedidosPendientes.ShowEditingIcon = false;
            this.dataGridViewPedidosPendientes.ShowRowErrors = false;
            this.dataGridViewPedidosPendientes.Size = new System.Drawing.Size(943, 163);
            this.dataGridViewPedidosPendientes.TabIndex = 3;
            this.dataGridViewPedidosPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidosPendientes_CellContentClick);
            // 
            // ver_pedidos
            // 
            this.ver_pedidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.75F, System.Drawing.FontStyle.Bold);
            this.ver_pedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.ver_pedidos.Frozen = true;
            this.ver_pedidos.HeaderText = "";
            this.ver_pedidos.Name = "ver_pedidos";
            this.ver_pedidos.ReadOnly = true;
            this.ver_pedidos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ver_pedidos.Text = "VER PEDIDO";
            this.ver_pedidos.UseColumnTextForButtonValue = true;
            this.ver_pedidos.Width = 5;
            // 
            // tabPageEntregados
            // 
            this.tabPageEntregados.Controls.Add(this.dataGridViewPedidosEntregados);
            this.tabPageEntregados.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEntregados.Location = new System.Drawing.Point(4, 35);
            this.tabPageEntregados.Name = "tabPageEntregados";
            this.tabPageEntregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntregados.Size = new System.Drawing.Size(949, 169);
            this.tabPageEntregados.TabIndex = 1;
            this.tabPageEntregados.Text = "ENTREGADOS";
            this.tabPageEntregados.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedidosEntregados
            // 
            this.dataGridViewPedidosEntregados.AllowUserToAddRows = false;
            this.dataGridViewPedidosEntregados.AllowUserToDeleteRows = false;
            this.dataGridViewPedidosEntregados.AllowUserToOrderColumns = true;
            this.dataGridViewPedidosEntregados.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPedidosEntregados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPedidosEntregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPedidosEntregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPedidosEntregados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPedidosEntregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPedidosEntregados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPedidosEntregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPedidosEntregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPedidosEntregados.ColumnHeadersHeight = 50;
            this.dataGridViewPedidosEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPedidosEntregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidosEntregados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPedidosEntregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidosEntregados.EnableHeadersVisualStyles = false;
            this.dataGridViewPedidosEntregados.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPedidosEntregados.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dataGridViewPedidosEntregados.MultiSelect = false;
            this.dataGridViewPedidosEntregados.Name = "dataGridViewPedidosEntregados";
            this.dataGridViewPedidosEntregados.ReadOnly = true;
            this.dataGridViewPedidosEntregados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPedidosEntregados.RowHeadersVisible = false;
            this.dataGridViewPedidosEntregados.RowTemplate.ReadOnly = true;
            this.dataGridViewPedidosEntregados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidosEntregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidosEntregados.ShowCellErrors = false;
            this.dataGridViewPedidosEntregados.ShowCellToolTips = false;
            this.dataGridViewPedidosEntregados.ShowEditingIcon = false;
            this.dataGridViewPedidosEntregados.ShowRowErrors = false;
            this.dataGridViewPedidosEntregados.Size = new System.Drawing.Size(943, 163);
            this.dataGridViewPedidosEntregados.TabIndex = 4;
            this.dataGridViewPedidosEntregados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidosEntregados_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Candara", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewButtonColumn1.Frozen = true;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "VER PEDIDO";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 89);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 6;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTop.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonAgregar, 5, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonEliminar, 4, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonEditar, 3, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonMarcarEntregado, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxBuscar, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(967, 89);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Candara", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitulo.Location = new System.Drawing.Point(0, 8);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(266, 73);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PEDIDOS";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAgregar.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Image = global::CapaPresentacion.Properties.Resources.agregar;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregar.Location = new System.Drawing.Point(900, 8);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(64, 78);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEliminar.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(830, 8);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(64, 78);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEditar.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(760, 8);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(64, 78);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonMarcarEntregado
            // 
            this.buttonMarcarEntregado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMarcarEntregado.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMarcarEntregado.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcarEntregado.Image = global::CapaPresentacion.Properties.Resources.marcarEntregadoPendiente;
            this.buttonMarcarEntregado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMarcarEntregado.Location = new System.Drawing.Point(539, 8);
            this.buttonMarcarEntregado.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonMarcarEntregado.Name = "buttonMarcarEntregado";
            this.buttonMarcarEntregado.Size = new System.Drawing.Size(215, 78);
            this.buttonMarcarEntregado.TabIndex = 5;
            this.buttonMarcarEntregado.Text = "Marcar Pedido Entregado/Pendiente";
            this.buttonMarcarEntregado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMarcarEntregado.UseVisualStyleBackColor = false;
            this.buttonMarcarEntregado.Click += new System.EventHandler(this.buttonMarcarEntregado_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscar.Controls.Add(this.tableLayoutPanelBuscar);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.Location = new System.Drawing.Point(329, 1);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(204, 84);
            this.groupBoxBuscar.TabIndex = 4;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Pedido";
            // 
            // tableLayoutPanelBuscar
            // 
            this.tableLayoutPanelBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBuscar.ColumnCount = 2;
            this.tableLayoutPanelBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.67347F));
            this.tableLayoutPanelBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.32653F));
            this.tableLayoutPanelBuscar.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanelBuscar.Controls.Add(this.textBoxBuscarNombre, 1, 0);
            this.tableLayoutPanelBuscar.Controls.Add(this.buttonRefrescar, 1, 1);
            this.tableLayoutPanelBuscar.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanelBuscar.Name = "tableLayoutPanelBuscar";
            this.tableLayoutPanelBuscar.RowCount = 2;
            this.tableLayoutPanelBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBuscar.Size = new System.Drawing.Size(196, 54);
            this.tableLayoutPanelBuscar.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(8, 5);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(55, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Código:";
            // 
            // textBoxBuscarNombre
            // 
            this.textBoxBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarNombre.Location = new System.Drawing.Point(69, 3);
            this.textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            this.textBoxBuscarNombre.Size = new System.Drawing.Size(124, 22);
            this.textBoxBuscarNombre.TabIndex = 1;
            this.textBoxBuscarNombre.TextChanged += new System.EventHandler(this.textBoxBuscarNombre_TextChanged);
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefrescar.BackColor = System.Drawing.Color.Orange;
            this.buttonRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefrescar.Location = new System.Drawing.Point(68, 27);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(126, 27);
            this.buttonRefrescar.TabIndex = 3;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(973, 353);
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.tableLayoutPanelPaginacion.ResumeLayout(false);
            this.tableLayoutPanelPaginacion.PerformLayout();
            this.tabControlPedidos.ResumeLayout(false);
            this.tabPagePendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosPendientes)).EndInit();
            this.tabPageEntregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosEntregados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.tableLayoutPanelBuscar.ResumeLayout(false);
            this.tableLayoutPanelBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPagePendientes;
        private System.Windows.Forms.TabPage tabPageEntregados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaginacion;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Label labelMensajes;
        private System.Windows.Forms.DataGridView dataGridViewPedidosPendientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBuscar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxBuscarNombre;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.DataGridViewButtonColumn ver_pedidos;
        private System.Windows.Forms.Button buttonMarcarEntregado;
        private System.Windows.Forms.DataGridView dataGridViewPedidosEntregados;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}
