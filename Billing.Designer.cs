namespace Student_Management
{
    partial class Billing
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.total_paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_payable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.due_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.payment_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paid_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.total_paid,
            this.total_payable,
            this.due_amount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // total_paid
            // 
            this.total_paid.Text = "Total Paid";
            this.total_paid.Width = 150;
            // 
            // total_payable
            // 
            this.total_payable.Text = "Total Payable";
            this.total_payable.Width = 150;
            // 
            // due_amount
            // 
            this.due_amount.Text = "Due Amount";
            this.due_amount.Width = 150;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.payment_date,
            this.paid_amount});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 136);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(459, 276);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // payment_date
            // 
            this.payment_date.Text = "Date of Payment";
            this.payment_date.Width = 200;
            // 
            // paid_amount
            // 
            this.paid_amount.Text = "Paid Amount";
            this.paid_amount.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader total_paid;
        private System.Windows.Forms.ColumnHeader total_payable;
        private System.Windows.Forms.ColumnHeader due_amount;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader payment_date;
        private System.Windows.Forms.ColumnHeader paid_amount;
        private System.Windows.Forms.Button button1;
    }
}