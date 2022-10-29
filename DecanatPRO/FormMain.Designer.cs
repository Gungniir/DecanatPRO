namespace DecanatPRO
{
    partial class FromMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromMain));
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // listViewStudents
            // 
            this.listViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewStudents.Location = new System.Drawing.Point(12, 12);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(409, 420);
            this.listViewStudents.TabIndex = 0;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            this.listViewStudents.SelectedIndexChanged += new System.EventHandler(this.listViewStudents_SelectedIndexChanged);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(427, 12);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(361, 30);
            this.buttonFill.TabIndex = 1;
            this.buttonFill.Text = "Заполнить систему тестовыми данными";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(427, 48);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(361, 30);
            this.buttonAddStudent.TabIndex = 2;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(427, 84);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(361, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить выбранных студентов";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(428, 121);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(359, 311);
            this.zedGraph.TabIndex = 4;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.listViewStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FromMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecanatPRO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonDelete;
        private ZedGraph.ZedGraphControl zedGraph;
    }
}

