using System.Drawing;
using System.Windows.Forms;

namespace Assistant;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        GroupBox_Time = new GroupBox();
        Label_Value_Firework = new Label();
        Label_Title_Firework = new Label();
        Label_Value_GameTime = new Label();
        Label_Title_GameTime = new Label();
        Label_Value_RealTime = new Label();
        Label_Title_RealTime = new Label();
        GroupBox_Time.SuspendLayout();
        SuspendLayout();
        // 
        // GroupBox_Time
        // 
        GroupBox_Time.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        GroupBox_Time.Controls.Add(Label_Value_Firework);
        GroupBox_Time.Controls.Add(Label_Title_Firework);
        GroupBox_Time.Controls.Add(Label_Value_GameTime);
        GroupBox_Time.Controls.Add(Label_Title_GameTime);
        GroupBox_Time.Controls.Add(Label_Value_RealTime);
        GroupBox_Time.Controls.Add(Label_Title_RealTime);
        GroupBox_Time.Location = new Point(12, 12);
        GroupBox_Time.Name = "GroupBox_Time";
        GroupBox_Time.Size = new Size(398, 354);
        GroupBox_Time.TabIndex = 0;
        GroupBox_Time.TabStop = false;
        GroupBox_Time.Text = "烟花助手";
        // 
        // Label_Value_Firework
        // 
        Label_Value_Firework.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Label_Value_Firework.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Label_Value_Firework.ForeColor = Color.Black;
        Label_Value_Firework.Location = new Point(6, 273);
        Label_Value_Firework.Name = "Label_Value_Firework";
        Label_Value_Firework.Size = new Size(386, 42);
        Label_Value_Firework.TabIndex = 5;
        Label_Value_Firework.Text = "299";
        Label_Value_Firework.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Label_Title_Firework
        // 
        Label_Title_Firework.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Label_Title_Firework.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Label_Title_Firework.ForeColor = Color.Lime;
        Label_Title_Firework.Location = new Point(6, 232);
        Label_Title_Firework.Name = "Label_Title_Firework";
        Label_Title_Firework.Size = new Size(386, 41);
        Label_Title_Firework.TabIndex = 4;
        Label_Title_Firework.Text = "烟花倒计时";
        Label_Title_Firework.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Label_Value_GameTime
        // 
        Label_Value_GameTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Label_Value_GameTime.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Label_Value_GameTime.ForeColor = SystemColors.Highlight;
        Label_Value_GameTime.Location = new Point(6, 137);
        Label_Value_GameTime.Name = "Label_Value_GameTime";
        Label_Value_GameTime.Size = new Size(386, 42);
        Label_Value_GameTime.TabIndex = 3;
        Label_Value_GameTime.Text = "15 : 24 : 00";
        Label_Value_GameTime.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Label_Title_GameTime
        // 
        Label_Title_GameTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Label_Title_GameTime.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Label_Title_GameTime.ForeColor = Color.Lime;
        Label_Title_GameTime.Location = new Point(6, 96);
        Label_Title_GameTime.Name = "Label_Title_GameTime";
        Label_Title_GameTime.Size = new Size(386, 41);
        Label_Title_GameTime.TabIndex = 2;
        Label_Title_GameTime.Text = "幻塔时间";
        Label_Title_GameTime.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Label_Value_RealTime
        // 
        Label_Value_RealTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Label_Value_RealTime.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Label_Value_RealTime.ForeColor = SystemColors.Highlight;
        Label_Value_RealTime.Location = new Point(6, 51);
        Label_Value_RealTime.Name = "Label_Value_RealTime";
        Label_Value_RealTime.Size = new Size(386, 33);
        Label_Value_RealTime.TabIndex = 1;
        Label_Value_RealTime.Text = "15 : 24 : 00";
        Label_Value_RealTime.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Label_Title_RealTime
        // 
        Label_Title_RealTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        Label_Title_RealTime.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Label_Title_RealTime.ForeColor = Color.Lime;
        Label_Title_RealTime.Location = new Point(6, 19);
        Label_Title_RealTime.Name = "Label_Title_RealTime";
        Label_Title_RealTime.Size = new Size(386, 32);
        Label_Title_RealTime.TabIndex = 0;
        Label_Title_RealTime.Text = "北京时间";
        Label_Title_RealTime.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDark;
        ClientSize = new Size(422, 378);
        Controls.Add(GroupBox_Time);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(438, 417);
        MinimizeBox = false;
        MinimumSize = new Size(438, 417);
        Name = "MainForm";
        Text = "幻塔助手";
        TopMost = true;
        Load += OnLoad;
        GroupBox_Time.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox GroupBox_Time;
    private Label Label_Title_RealTime;
    private Label Label_Value_GameTime;
    private Label Label_Title_GameTime;
    private Label Label_Value_RealTime;
    private Label Label_Value_Firework;
    private Label Label_Title_Firework;
}
