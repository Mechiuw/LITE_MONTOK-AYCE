public class InputBuilder    
{
    public T Build<T>(Dictionary<string, Type> fields) where T : new() { // buat T object baru
        var obj = new T(); // inisiasi object/entity nya bentuk apa 
        
        foreach (var field in fields)  // loop field dictionary
        {
            Console.Write($"{field.Key}"); // print key nya apa saja
            string input = Console.ReadLine(); // terima input setiap kali ada field

            var prop = typeof(T).GetProperty(field.Key); // 
            if(prop != null)
            {
                object value = Convert.ChangeType(input, field.Value);
                prop.SetValue(obj, value);
            }
        }

        return obj;
    }
}