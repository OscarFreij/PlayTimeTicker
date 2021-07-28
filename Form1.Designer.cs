
namespace PlayTimeTicker
{
    partial class Form1
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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.countdownTable = new System.Windows.Forms.TableLayoutPanel();
            this.clock = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.playerList = new System.Windows.Forms.ListView();
            this.timesPlayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adminTable = new System.Windows.Forms.TableLayoutPanel();
            this.addNameBtn = new System.Windows.Forms.Button();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.clockStartStopBtn = new System.Windows.Forms.Button();
            this.mainTable.SuspendLayout();
            this.countdownTable.SuspendLayout();
            this.adminTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Controls.Add(this.countdownTable, 0, 0);
            this.mainTable.Controls.Add(this.playerList, 0, 1);
            this.mainTable.Controls.Add(this.adminTable, 0, 2);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainTable.Size = new System.Drawing.Size(584, 761);
            this.mainTable.TabIndex = 0;
            // 
            // countdownTable
            // 
            this.countdownTable.ColumnCount = 1;
            this.countdownTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countdownTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.countdownTable.Controls.Add(this.clock, 0, 0);
            this.countdownTable.Controls.Add(this.progressBar, 0, 1);
            this.countdownTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownTable.Location = new System.Drawing.Point(3, 3);
            this.countdownTable.Name = "countdownTable";
            this.countdownTable.RowCount = 2;
            this.countdownTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.countdownTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.countdownTable.Size = new System.Drawing.Size(578, 144);
            this.countdownTable.TabIndex = 0;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clock.Font = new System.Drawing.Font("MS Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.Location = new System.Drawing.Point(3, 0);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(572, 102);
            this.clock.TabIndex = 0;
            this.clock.Text = "00:00";
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 105);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(572, 36);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // playerList
            // 
            this.playerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timesPlayed,
            this.playerName,
            this.date});
            this.playerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerList.HideSelection = false;
            this.playerList.Location = new System.Drawing.Point(3, 153);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(578, 485);
            this.playerList.TabIndex = 1;
            this.playerList.TabStop = false;
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.View = System.Windows.Forms.View.Details;
            // 
            // timesPlayed
            // 
            this.timesPlayed.Text = "Gånger spelat";
            this.timesPlayed.Width = 83;
            // 
            // playerName
            // 
            this.playerName.Text = "Namn";
            this.playerName.Width = 332;
            // 
            // date
            // 
            this.date.Text = "Datum";
            this.date.Width = 158;
            // 
            // adminTable
            // 
            this.adminTable.ColumnCount = 2;
            this.adminTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.44637F));
            this.adminTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.55363F));
            this.adminTable.Controls.Add(this.addNameBtn, 0, 1);
            this.adminTable.Controls.Add(this.nameInputBox, 0, 0);
            this.adminTable.Controls.Add(this.clockStartStopBtn, 1, 1);
            this.adminTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTable.Location = new System.Drawing.Point(3, 644);
            this.adminTable.Name = "adminTable";
            this.adminTable.RowCount = 2;
            this.adminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adminTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adminTable.Size = new System.Drawing.Size(578, 114);
            this.adminTable.TabIndex = 2;
            // 
            // addNameBtn
            // 
            this.addNameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNameBtn.Location = new System.Drawing.Point(3, 60);
            this.addNameBtn.Name = "addNameBtn";
            this.addNameBtn.Size = new System.Drawing.Size(511, 51);
            this.addNameBtn.TabIndex = 0;
            this.addNameBtn.Text = "Läggtill namn i listan";
            this.addNameBtn.UseVisualStyleBackColor = true;
            this.addNameBtn.Click += new System.EventHandler(this.addNameBtn_Click);
            // 
            // nameInputBox
            // 
            this.adminTable.SetColumnSpan(this.nameInputBox, 2);
            this.nameInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameInputBox.Location = new System.Drawing.Point(3, 3);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(572, 49);
            this.nameInputBox.TabIndex = 1;
            this.nameInputBox.WordWrap = false;
            // 
            // clockStartStopBtn
            // 
            this.clockStartStopBtn.BackColor = System.Drawing.Color.Orange;
            this.clockStartStopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockStartStopBtn.Location = new System.Drawing.Point(520, 60);
            this.clockStartStopBtn.Name = "clockStartStopBtn";
            this.clockStartStopBtn.Size = new System.Drawing.Size(55, 51);
            this.clockStartStopBtn.TabIndex = 2;
            this.clockStartStopBtn.Text = "Starta";
            this.clockStartStopBtn.UseVisualStyleBackColor = false;
            this.clockStartStopBtn.Click += new System.EventHandler(this.clockStartStopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.mainTable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Speltids schema";
            this.mainTable.ResumeLayout(false);
            this.countdownTable.ResumeLayout(false);
            this.countdownTable.PerformLayout();
            this.adminTable.ResumeLayout(false);
            this.adminTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel countdownTable;
        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.ColumnHeader timesPlayed;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel adminTable;
        private System.Windows.Forms.Button addNameBtn;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button clockStartStopBtn;
    }
}

