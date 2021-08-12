using Single_Responsibility_Principle.WidgetModel;

namespace Single_Responsibility_Principle.WidgetClassesRIGHT
{
    public class WidgetFactory
    {
        public Widget CreateWidget(string name)
        {
            return new() {Name = name};
        }
    }
}