namespace RichKokuban
{
    public class KokubanString
    {
        private string text;

        internal KokubanString(){}
        
        internal KokubanString(string str)
        {
            text = str;
        }

        public static KokubanString operator +(string a, KokubanString b)
        {
            var s = a + b.text;
            return new KokubanString(s);
        }

        public static KokubanString operator +(KokubanString a, string b)
        {
            a.text += b;
            return a;
        }
    
        public static KokubanString operator +(KokubanString a, KokubanString b)
        {
            return new KokubanString(a.text + b.text);
        }

        public override string ToString() => text;

        public static implicit operator string(KokubanString self)
        {
            return self.text;
        }
    }
}
