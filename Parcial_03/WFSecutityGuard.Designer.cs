using System.ComponentModel;

namespace Parcial_03
{
    partial class WFSecutityGuard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WFSecutityGuard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabRegistros = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabUScrear = new System.Windows.Forms.TabPage();
            this.tabUSver = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabExit = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabRegistros.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabUSver.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabExit.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabRegistros);
            this.tabControl1.Controls.Add(this.tabExit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 513);
            this.tabControl1.TabIndex = 1;
            // 
            // TabRegistros
            // 
            this.TabRegistros.BackColor = System.Drawing.Color.Transparent;
            this.TabRegistros.Controls.Add(this.tabControl2);
            this.TabRegistros.Location = new System.Drawing.Point(4, 22);
            this.TabRegistros.Name = "TabRegistros";
            this.TabRegistros.Padding = new System.Windows.Forms.Padding(3);
            this.TabRegistros.Size = new System.Drawing.Size(812, 487);
            this.TabRegistros.TabIndex = 0;
            this.TabRegistros.Text = "Registros";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabUScrear);
            this.tabControl2.Controls.Add(this.tabUSver);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(806, 481);
            this.tabControl2.TabIndex = 0;
            // 
            // tabUScrear
            // 
            this.tabUScrear.Location = new System.Drawing.Point(4, 22);
            this.tabUScrear.Name = "tabUScrear";
            this.tabUScrear.Padding = new System.Windows.Forms.Padding(3);
            this.tabUScrear.Size = new System.Drawing.Size(798, 455);
            this.tabUScrear.TabIndex = 0;
            this.tabUScrear.Text = "Crear US";
            this.tabUScrear.UseVisualStyleBackColor = true;
            // 
            // tabUSver
            // 
            this.tabUSver.Controls.Add(this.tableLayoutPanel1);
            this.tabUSver.Location = new System.Drawing.Point(4, 22);
            this.tabUSver.Name = "tabUSver";
            this.tabUSver.Size = new System.Drawing.Size(798, 455);
            this.tabUSver.TabIndex = 2;
            this.tabUSver.Text = "Ver US";
            this.tabUSver.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.26852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.73148F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 455);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(792, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabExit
            // 
            this.tabExit.Controls.Add(this.tableLayoutPanel6);
            this.tabExit.Location = new System.Drawing.Point(4, 22);
            this.tabExit.Name = "tabExit";
            this.tabExit.Size = new System.Drawing.Size(812, 487);
            this.tabExit.TabIndex = 3;
            this.tabExit.Text = "Regresar";
            this.tabExit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel6.BackgroundImage")));
            this.tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.button11, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91842F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.08159F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(812, 487);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // button11
            // 
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.BackColor = System.Drawing.Color.MediumPurple;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(165, 443);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(481, 41);
            this.button11.TabIndex = 4;
            this.button11.Text = "Regresar al Login";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MediumPurple;
            this.tableLayoutPanel6.SetColumnSpan(this.label11, 3);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(806, 65);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hoy, Separados somos mas fuertes.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.MediumPurple;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(652, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 47);
            this.label12.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.MediumPurple;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 47);
            this.label13.TabIndex = 3;
            // 
            // WFSecutityGuard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "WFSecutityGuard";
            this.Text = "WFSecutityGuard";
            this.tabControl1.ResumeLayout(false);
            this.TabRegistros.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabUSver.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabExit.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabPage TabRegistros;
        private System.Windows.Forms.TabPage tabUScrear;
        private System.Windows.Forms.TabPage tabUSver;

        #endregion
    }
}