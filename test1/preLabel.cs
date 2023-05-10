namespace test1
{
    class preLabel : Label
    {
        // amazing time saving technique (i feel like a genius)
        public preLabel(string type, string value, int vOffset)
        {
            this.Location = new System.Drawing.Point(10, vOffset);
            this.AutoSize = true;
            this.Text = type + ": " + value;
        }
    }
}