using UnityEngine;

namespace RichKokuban
{
    public class Align : RichTextTag
    {
        private readonly string align;
        protected override KokubanString Tagging(KokubanString str)
        {
            if(string.IsNullOrEmpty(align)) return str;
            return $@"<align=""{align}"">" + str;
        }

        internal override KokubanString StartTagging(KokubanString str)
        {
            if(string.IsNullOrEmpty(align)) return str;
            return $@"<align=""{align}"">" + str;
        }

        private Align(string align)
        {
            this.align = align;
        }

        public static readonly Align Right = new Align("right");
        public static readonly Align Left = new Align("left");
        public static readonly Align Center = new Align("center");
    }

    public class Color : RichTextTag
    {
        private readonly UnityEngine.Color color = UnityEngine.Color.white;

        protected override KokubanString Tagging(KokubanString str)
        {
            return $@"<color=#{ColorUtility.ToHtmlStringRGB(color)}>" + str + @"</color>";
        }

        internal override KokubanString StartTagging(KokubanString str)
        {
            return $@"<color=#{ColorUtility.ToHtmlStringRGB(color)}>" + str;
        }

        public Color(UnityEngine.Color color)
        {
            this.color = color;
        }
    }
    
    public class Size : RichTextTag
    {
        private int sizePercentage = 100;

        public Size(int sizePercentage)
        {
            this.sizePercentage = sizePercentage;
        }

        public KokubanString this[string str, int percentage]
        {
            get
            {
                sizePercentage = percentage;
                return Tagging(new(str));
            }
        }

        public KokubanString this[KokubanString str, int percentage] => this[(string)str, percentage];
        
        public Size this[int percentage] => new(percentage);

        protected override KokubanString Tagging(KokubanString str)
        {
            return $@"<size={sizePercentage}%>" + str + @"</size>";
        }

        internal override KokubanString StartTagging(KokubanString str)
        {
            return $@"<size={sizePercentage}%>" + str;
        }
    }
    
    public abstract class RichTextTag
    {
        protected abstract KokubanString Tagging(KokubanString str);
        internal abstract KokubanString StartTagging(KokubanString str);

        public KokubanString this[string str] => Tagging(new(str));
        public KokubanString this[KokubanString str] => Tagging(str);

        public static implicit operator KokubanString(RichTextTag self)
        {
            return self.StartTagging(new KokubanString());
        }
        
        public static implicit operator string(RichTextTag self)
        {
            return self.StartTagging(new KokubanString());
        }
    }
}
