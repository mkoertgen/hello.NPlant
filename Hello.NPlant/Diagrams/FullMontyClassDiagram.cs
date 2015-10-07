using System;
using NPlant;

namespace Hello.NPlant.Diagrams
{
    public class FullMontyClassDiagram : ClassDiagram
    {
        public FullMontyClassDiagram()
        {
            GenerationOptions.ShowMethods();

            AddClass<Foo>();
        }

        public class Foo
        {
            public string SomeString;
            public Bar TheBar;
            public Baz<Arg1, Arg2> TheBaz;
            public Baz2<Arg1, Arg2> TheBaz2;

            public void DoSomethingOnFoo() { }
            public void DoSomethingOnFoo(string parm1) { }
            public void DoSomethingOnFoo(string parm1, DateTime? parm2, Bar parm3) { }
        }

        public class Bar
        {
            public DateTime? SomeDate;

            public void DoSomethingOnBar() { }
            public void DoSomethingOnBar(string parm1) { }
            public void DoSomethingOnBar(string parm1, DateTime? parm2, Baz<Arg1, Arg2> parm3) { }
        }

        public class Baz<T1, T2>
        {
            public Foo TheFoo;

            public T1 Arg1;

            public T2 Arg2;
        }

        public class Baz2<T1, T2>
        {
            public string Whatever;
        }

        public class Arg1 { }
        public class Arg2 { }
    }
}