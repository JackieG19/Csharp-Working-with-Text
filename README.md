## String

**Formatting**
```
ToLower() // "hello world"

ToUpper() // "HELLO WORLD"

Trim()
```

**Searching**
```
IndexOf('a')

LastIndexOf("Hello")
```

**Substrings**
```
Substring(startIndex)

Substring(startIndex, length)
```

**Replacing**
```
Replace('a', '!')

Replace("mosh", "moshfegh")
```

**Null checking**
```
String.IsNullOrEmpty(str)

String.IsNullOrWhiteSpace(str)
```

**Splitting**
```
str.Split('')
```

**Converting Strings to Numbers**
```
string s = "1234";

int i = int.Parse(s);

int j = Convert.ToInt32();
```

**Converting Numbers to Strings**
```
int i = 1234;

string s = i.ToString(); // "1234"

string s = i.ToString("C"); // "$1,234.00"

string s = i.ToString("CO"); // "$1,234"
```
**Format Strings**

| Format Specifier | Description | Example  | 
| ------------- | ------------- | ------------- |
| c or C | Currency | 123456(C) -> $123,456 |
| d or D | Decimal | 1234(D6) -> 0001234 |
| e or E | Exponential | 1052.032911756(E) -> 1.052033E+003|
| f or F | Fixed Point | 1234.567(F1) -> 1234.5 |
| x or X | Hexadecimal | 255(X) -> FF |
___

**StringBuilder**
- Defined in System.Text
- A mutable string
- Easy and fast to create and manipulate strings

**Not for Searching**
- IndexOf()
- LastIndexOf()
- Contains()
- StartsWith()

**String Manipulation Methods**
- Append()
- Insert()
- Remove()
- Replace()
- Clear()
___

Next -> [Working with Files](https://github.com/JackieG19/Csharp-Working-with-Files)
