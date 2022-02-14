using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierEx
{
    class Demo
    {
        public Demo()
        {
            // 내부에서 접근
            Demo.public_method();
            Demo.private_method();
            Demo.protected_method();
            Demo.internal_method();
            Demo.protected_internal_method();
            Demo.private_protected_method();
        }

        // public 접근 제한자
        public static void public_method()
        {

        }
        // private 접근 제한자
        private static void private_method()
        {

        }
        // protected 접근 제한자
        protected static void protected_method()
        {

        }
        // internal 접근 제한자
        internal static void internal_method()
        {

        }

        // protected internal 접근 제한자
        protected internal static void protected_internal_method() { }
        // privated protected 접근 제한자
        private protected static void private_protected_method() { }


       
    }

    class Demo2 : Demo
    {
        public Demo2()
        {
            Demo.public_method();
            Demo.protected_internal_method();
            Demo.protected_method();
            Demo.private_protected_method();
            Demo.internal_method();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 접근 제한자 / 한정자 (Access Modifier)
            // public, private, protected, internal, protected internal, private protected

            //** 클래스 멤버에 한정자가 설정되지 않았을 경우 무조건 private으로 자동 지정된다.
            /*
             * 호출자의 위치	                public	protected internal	protected	internal	private protected	private
                클래스 내	                 ✔️	        ✔️	                ✔️	        ✔️	            ✔️	            ✔️
                파생 클래스(동일한 어셈블리)	 ✔️	        ✔️	                ✔️	        ✔️	            ✔️	            ❌
                비파생 클래스(동일한 어셈블리)	 ✔️	        ✔️	                ❌	        ✔️	            ❌	            ❌
                파생 클래스(다른 어셈블리)	 ✔️	        ✔️	                ✔️	        ❌	            ❌	            ❌
                비파생 클래스(다른 어셈블리)	 ✔️	        ❌	                ❌          ❌             ❌              ❌
            */
            Demo.public_method();
            Demo.internal_method();
            Demo.protected_internal_method();

        }
    }
}
