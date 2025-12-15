public class InputBuilder    
{
    public T Build<T>(Dictionary<string, Type> fields) where T : new() {
        var obj = new T(); // inisiasi object/entity nya bentuk apa 
        
        foreach (var field in fields) 
        {
            Console.Write($"{field.Key}");
            string input = Console.ReadLine();

            var prop = typeof(T).GetProperty(field.Key);
            if(prop != null)
            {
                object value = Convert.ChangeType(input, field.Value);
                prop.SetValue(obj, value);
            }
        }

        return obj;
    }
}