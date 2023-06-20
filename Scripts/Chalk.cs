namespace RichKokuban
{
    public class Chalk
    {
        #region Align
        public static KokubanString Right => Align.Right.StartTagging(new KokubanString());

        public static KokubanString Left => Align.Left.StartTagging(new KokubanString());

        public static KokubanString Center => Align.Center.StartTagging(new KokubanString());
        #endregion

        #region Color
        public static KokubanString Color(UnityEngine.Color color) => new Color(color).StartTagging(new KokubanString());
        public static KokubanString Color(UnityEngine.Color color, string str) => new Color(color)[str];
        public static readonly Color Black = new Color(UnityEngine.Color.black);
        public static readonly Color White = new Color(UnityEngine.Color.white);
        public static readonly Color Red = new Color(UnityEngine.Color.red);
        public static readonly Color Green = new Color(UnityEngine.Color.green);
        public static readonly Color Blue = new Color(UnityEngine.Color.blue);
        public static readonly Color Yellow = new Color(UnityEngine.Color.yellow);
        public static readonly Color Grey = new Color(UnityEngine.Color.grey);
        public static readonly Color Cyan = new Color(UnityEngine.Color.cyan);
        public static readonly Color Magenta = new Color(UnityEngine.Color.magenta);
        #endregion
        
        #region Size
        public static Size Size => new(100);
        #endregion
    }
}
