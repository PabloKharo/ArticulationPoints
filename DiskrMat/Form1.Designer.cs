namespace DiskrMat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStripField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonHand = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonVertex = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.cageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numbCageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStripField.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripField
            // 
            this.contextMenuStripField.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineColorToolStripMenuItem,
            this.CageToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.cageSizeToolStripMenuItem});
            this.contextMenuStripField.Name = "contextMenuStripField";
            this.contextMenuStripField.Size = new System.Drawing.Size(155, 92);
            // 
            // CageToolStripMenuItem
            // 
            this.CageToolStripMenuItem.Name = "CageToolStripMenuItem";
            this.CageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CageToolStripMenuItem.Text = "Фон в клетку";
            this.CageToolStripMenuItem.Click += new System.EventHandler(this.сageToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dotToolStripMenuItem.Text = "Фон в точку";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lineColorToolStripMenuItem.Text = "Цвет ребра";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackToolStripMenuItem.Text = "Черный";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Красный";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Зеленый";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Синий";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem.Text = "Свой";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteAll.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteAll.BackgroundImage = global::DiskrMat.Properties.Resources.Delete;
            this.buttonDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteAll.Location = new System.Drawing.Point(201, 5);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(48, 48);
            this.buttonDeleteAll.TabIndex = 5;
            this.buttonDeleteAll.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonDeleteAll, "Очистить экран\r\nНажмите для удаления всех элементов");
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDo.BackgroundImage = global::DiskrMat.Properties.Resources.start1;
            this.buttonDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDo.Location = new System.Drawing.Point(745, 5);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(48, 48);
            this.buttonDo.TabIndex = 4;
            this.buttonDo.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonDo, "Вывод точек сочленения");
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.ButtonDo_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.BackgroundImage = global::DiskrMat.Properties.Resources.rubber;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.Location = new System.Drawing.Point(147, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(48, 48);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonDelete, "Удаление вершины или ребра\r\nНажмите ЛКМ по вершине или ребру");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonHand
            // 
            this.buttonHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHand.BackgroundImage = global::DiskrMat.Properties.Resources.hand;
            this.buttonHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHand.FlatAppearance.BorderSize = 0;
            this.buttonHand.Location = new System.Drawing.Point(3, 5);
            this.buttonHand.Name = "buttonHand";
            this.buttonHand.Size = new System.Drawing.Size(48, 48);
            this.buttonHand.TabIndex = 0;
            this.buttonHand.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonHand, "Перемещение вершины\r\nНажмите ЛКМ по вершине, а затем ЛКМ по месту");
            this.buttonHand.UseVisualStyleBackColor = true;
            this.buttonHand.Click += new System.EventHandler(this.ButtonHand_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLine.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLine.BackgroundImage = global::DiskrMat.Properties.Resources.line1;
            this.buttonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLine.Location = new System.Drawing.Point(99, 5);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(48, 48);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonLine, "Создание ребра\r\nНажмите ЛКМ по первой вершине, а затем ЛКМ по второй\r\nНажмите ПКМ" +
        ", чтобы изменить цвет ребра");
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // buttonVertex
            // 
            this.buttonVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVertex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVertex.BackgroundImage = global::DiskrMat.Properties.Resources.Point;
            this.buttonVertex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVertex.Location = new System.Drawing.Point(51, 5);
            this.buttonVertex.Name = "buttonVertex";
            this.buttonVertex.Size = new System.Drawing.Size(48, 48);
            this.buttonVertex.TabIndex = 1;
            this.buttonVertex.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonVertex, "Создание вершины\r\nНажмите ЛКМ по месту");
            this.buttonVertex.UseVisualStyleBackColor = true;
            this.buttonVertex.Click += new System.EventHandler(this.ButtonVertex_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.buttonDo);
            this.panelBottom.Controls.Add(this.buttonDeleteAll);
            this.panelBottom.Controls.Add(this.buttonDelete);
            this.panelBottom.Controls.Add(this.buttonLine);
            this.panelBottom.Controls.Add(this.buttonVertex);
            this.panelBottom.Controls.Add(this.buttonHand);
            this.panelBottom.Location = new System.Drawing.Point(0, 390);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 60);
            this.panelBottom.TabIndex = 6;
            // 
            // cageSizeToolStripMenuItem
            // 
            this.cageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numbCageSizeToolStripMenuItem});
            this.cageSizeToolStripMenuItem.Name = "cageSizeToolStripMenuItem";
            this.cageSizeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cageSizeToolStripMenuItem.Text = "Размер клетки";
            // 
            // numbCageSizeToolStripMenuItem
            // 
            this.numbCageSizeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numbCageSizeToolStripMenuItem.MaxLength = 3;
            this.numbCageSizeToolStripMenuItem.Name = "numbCageSizeToolStripMenuItem";
            this.numbCageSizeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numbCageSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.numbCageSizeToolStripMenuItem.Text = "100";
            this.numbCageSizeToolStripMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbCageSizeToolStripMenuItem_KeyPress);
            this.numbCageSizeToolStripMenuItem.TextChanged += new System.EventHandler(this.numbCageSizeToolStripMenuItem_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripField;
            this.Controls.Add(this.panelBottom);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(372, 236);
            this.Name = "Form1";
            this.Text = "Articulalation points by pablokharo";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.contextMenuStripField.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHand;
        private System.Windows.Forms.Button buttonVertex;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripField;
        private System.Windows.Forms.ToolStripMenuItem CageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox numbCageSizeToolStripMenuItem;
    }
}

