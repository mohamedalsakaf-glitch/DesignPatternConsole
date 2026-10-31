using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Structural
{
    // Composite Pattern allows you to compose objects into tree structures to represent part-whole hierarchies.
    // It lets clients treat individual objects and compositions of objects uniformly.
    internal class CompositePattern
    {
        public CompositePattern() { }
        public CompositePattern(string pattern) { }

        // Component
        public interface IComponent
        {
            void Display(int depth);
        }
        public class Component : IComponent
        {
            public virtual void Display(int depth) => Console.WriteLine(new string('-', depth) + " Component");

        }
        // Leaf
        public class Leaf : Component
        {
            private readonly string _name;

            public Leaf(string name)
            {
                _name = name;
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new string('-', depth) + _name);
            }
        }

        // Composite
        public class Composite : Component
        {
            private readonly List<Component> _children = new();
            public void Add(Component component) => _children.Add(component);
            public void Remove(Component component) => _children.Remove(component);
            public override void Display(int depth)
            {
                Console.WriteLine(new string('-', depth) + " Composite");
                foreach (var child in _children)
                {
                    child.Display(depth + 2);
                }
            }
        }
        

    }
}
