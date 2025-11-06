public class Student
{
    private string _fullName;

    private int _age;

    public string FullName
    {
        get => _fullName;
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "The name should not be empty");

            _fullName = value;
        }
    }

    public int Age => _age;

    public Student(string name, int age) 
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name), "The name should not be empty");

        if (age < 16)
            throw new ArgumentException("The student age should be at least 16", nameof(name));

        _fullName = name;
        _age = age;
    }
}