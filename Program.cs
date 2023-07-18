using LINQTestFile;

Person person1 = new Person(1, "John", "Doe", 25);
Person person2 = new Person(2, "John", "Smith", 30);
Person person3 = new Person(3, "Michael", "Johnson", 42);
Person person4 = new Person(4, "Emily", "Brown", 28);
Person person5 = new Person(5, "Daniel", "Davis", 35);
Person person6 = new Person(6, "John", "Smith", 79);
Person person7 = new Person(7, "David", "Miller", 52);
Person person8 = new Person(8, "Emma", "Anderson", 30);
Person person9 = new Person(9, "John", "Taylor", 40);
Person person10 = new Person(10, "Olivia", "Smith", 30);

List<Person> people = new List<Person>
{
    person1,
    person2,
    person3,
    person4,
    person5,
    person6,
    person7,
    person8,
    person9,
    person10,
};

Address address1 = new Address(1, 11, "123 Main Street");
Address address2 = new Address(2, 101, "456 Elm Avenue");
Address address3 = new Address(3, 51, "789 Oak Lane");
Address address4 = new Address(4, 71, "321 Pine Road");
Address address5 = new Address(5, 61, "654 Cedar Drive");
Address address6 = new Address(6, 21, "987 Maple Court");
Address address7 = new Address(7, 81, "135 Birch Street");
Address address8 = new Address(8, 31, "864 Willow Avenue");
Address address9 = new Address(9, 41, "297 Oakwood Lane");
Address address10 = new Address(10, 9, "630 Pinecrest Road");

List<Address> addresses = new List<Address>
{
    address1 , address2 , address3 , address4 , address5 , address6 , address7 , address8, address9 , address10,
};

Subjects subject1 = new Subjects(1, 1, "Mathematics", 85);
Subjects subject2 = new Subjects(2, 1, "Science", 92);
Subjects subject3 = new Subjects(3, 2, "English", 78);
Subjects subject4 = new Subjects(4, 2, "History", 89);
Subjects subject5 = new Subjects(5, 3, "Geography", 91);
Subjects subject6 = new Subjects(6, 3, "Physics", 87);
Subjects subject7 = new Subjects(7, 4, "Chemistry", 90);
Subjects subject8 = new Subjects(8, 4, "Biology", 88);
Subjects subject9 = new Subjects(9, 5, "Computer Scien;ce", 95);
Subjects subject10 = new Subjects(10, 5, "Mathematics", 82);
Subjects subject11 = new Subjects(11, 6, "English", 79);
Subjects subject12 = new Subjects(12, 6, "History", 88);
Subjects subject13 = new Subjects(13, 7, "Physics", 91);
Subjects subject14 = new Subjects(14, 7, "Chemistry", 89);
Subjects subject15 = new Subjects(15, 8, "Biology", 87);
Subjects subject16 = new Subjects(16, 8, "Computer Science", 92);
Subjects subject17 = new Subjects(17, 9, "Mathematics", 94);
Subjects subject18 = new Subjects(18, 9, "Geography", 86);
Subjects subject19 = new Subjects(19, 10, "History", 83);
Subjects subject20 = new Subjects(20, 10, "English", 80);

List<Subjects> subjects = new List<Subjects>
{
    subject1, subject2, subject3, subject4, subject5, subject6,
    subject7, subject8, subject9, subject10, subject11, subject12,
    subject13, subject14, subject15, subject16, subject17, subject18,
    subject19, subject20
};

List<int> numbers = new List<int>
{
    1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,1,2,3,4,5,6,7,8,9
};

Users user1 = new Users(1, "john123", "password123");
Users user2 = new Users(2, "emma456", "securepass");
Users user3 = new Users(3, "alex789", "abc123");
Users user4 = new Users(4, "sarah12", "password456");
Users user5 = new Users(5, "michael34", "pass123");
Users user6 = new Users(6, "lily789", "securepass123");
Users user7 = new Users(7, "james45", "passabc");
Users user8 = new Users(8, "sophia12", "password789");
Users user9 = new Users(9, "david34", "abcxyz");
Users user10 = new Users(10, "olivia56", "pass456");
Users user11 = new Users(11, "william78", "abc123xyz");
Users user12 = new Users(12, "ava90", "securepassword");
Users user13 = new Users(13, "noah12", "pass123abc");
Users user14 = new Users(14, "mia34", "passwordxyz");
Users user15 = new Users(15, "tatsumaki", "passwordpapa");
Users user16 = new Users(16, "charlotte78", "passxyz");
Users user17 = new Users(17, "ethan90", "passwordabc");
Users user18 = new Users(18, "amelia12", "xyzabc");
Users user19 = new Users(19, "logan34", "pass789");
Users user20 = new Users(20, "harper56", "abcxyz123");
Users user21 = new Users(21, "ben78", "secure123");
Users user22 = new Users(22, "abigail90", "pass789xyz");
Users user23 = new Users(23, "lucas12", "abc123xyz");
Users user24 = new Users(24, "emily34", "securepassword123");
Users user25 = new Users(25, "jackson56", "pass123xyz");
Users user26 = new Users(26, "sofia78", "passwordabc123");
Users user27 = new Users(27, "aiden90", "xyzabc123");
Users user28 = new Users(28, "avery12", "pass789xyz");
Users user29 = new Users(29, "sebastian34", "abc123xyz789");
Users user30 = new Users(30, "scarlett56", "securepassabc");
Users user31 = new Users(31, "muhammad78", "passxyz123");
Users user32 = new Users(32, "camila90", "passwordabcxyz");
Users user33 = new Users(33, "henry12", "xyzabc123789");
Users user34 = new Users(34, "victoria34", "pass789xyzabc");
Users user35 = new Users(35, "samuel56", "abc123xyz789");
Users user36 = new Users(36, "layla78", "securepasswordabc");
Users user37 = new Users(37, "matthew90", "pass123xyzabc");
Users user38 = new Users(38, "riley12", "passwordabc123xyz");
Users user39 = new Users(39, "joseph34", "xyzabc123789");
Users user40 = new Users(40, "grace56", "pass789xyzabc");
Users user41 = new Users(41, "levi78", "abc123xyz789");
Users user42 = new Users(42, "zoey90", "securepassabcxyz");
Users user43 = new Users(43, "daniel12", "passxyz123abc");
Users user44 = new Users(44, "aubrey34", "passwordabcxyz123");
Users user45 = new Users(45, "oliver56", "xyzabc123789");
Users user46 = new Users(46, "mia78", "pass789xyzabc123");
Users user47 = new Users(47, "emma90", "abc123xyz789");
Users user48 = new Users(48, "william12", "securepasswordabcxyz");
Users user49 = new Users(49, "ava34", "pass123xyzabc789");
Users user50 = new Users(50, "jacob56", "passwordabc123xyz789");
Users user51 = new Users(51, "charlotte78", "xyzabc123789pass");
Users user52 = new Users(52, "noah90", "securepassabc123xyz");
Users user53 = new Users(53, "sophia12", "pass123xyzabc789");
Users user54 = new Users(54, "logan34", "passwordabcxyz123789");
Users user55 = new Users(55, "olivia56", "xyzabc123789pass");
Users user56 = new Users(56, "ethan78", "securepassabc123xyz");
Users user57 = new Users(57, "amelia90", "pass123xyzabc789");
Users user58 = new Users(58, "lucas12", "passwordabcxyz123789");
Users user59 = new Users(59, "emily34", "xyzabc123789pass");
Users user60 = new Users(60, "jackson56", "securepassabc123xyz");
Users user61 = new Users(61, "abigail78", "pass123xyzabc789");
Users user62 = new Users(62, "aiden90", "passwordabcxyz123789");
Users user63 = new Users(63, "avery12", "xyzabc123789pass");
Users user64 = new Users(64, "scarlett34", "securepassabc123xyz");
Users user65 = new Users(65, "muhammad56", "pass123xyzabc789");
Users user66 = new Users(66, "camila78", "passwordabcxyz123789");
Users user67 = new Users(67, "henry90", "xyzabc123789pass");
Users user68 = new Users(68, "victoria12", "securepassabc123xyz");
Users user69 = new Users(69, "samuel34", "pass123xyzabc789");
Users user70 = new Users(70, "layla56", "passwordabcxyz123789");

List<Users> userList = new List<Users>{
            user1, user2, user3, user4, user5, user6, user7, user8, user9, user10,
            user11, user12, user13, user14, user15, user16, user17, user18, user19, user20,
            user21, user22, user23, user24, user25, user26, user27, user28, user29, user30,
            user31, user32, user33, user34, user35, user36, user37, user38, user39, user40,
            user41, user42, user43, user44, user45, user46, user47, user48, user49, user50,
            user51, user52, user53, user54, user55, user56, user57, user58, user59, user60,
            user61, user62, user63, user64, user65, user66, user67, user68, user69, user70,
        };



//Test 01 for reading data

/*
var list = (from per in people 
            select per).Reverse().ToList();

for(int i = 0; i < list.Count; i++)
{
    if (list[i].id < 10)
    {
        Console.WriteLine(list[i].id + "  :" + list[i].fName + " " + list[i].lName + " age: " + list[i].age);
    }
    else
    {
        Console.WriteLine(list[i].id + " :" + list[i].fName + " " + list[i].lName + " age: " + list[i].age);
    }
}
*/

//Test 02 for Any

/*
var query = (from per in people
             select per).Any(x => x.age > 70);

Console.WriteLine(query);
*/

//Test 03 for contains

/*
var isExist = (from per in people
               select per.fName).Contains("John");

Console.WriteLine(isExist);
*/

//Test 04 for join

/*
var combined = (from per in people
               join address in addresses
               on per.id equals address.PersonId
               join mark in subjects
               on per.id equals mark.PersonId
               select new
               {
                   id = per.id,
                   fname = per.fName,
                   lname = per.lName,
                   address = address.addressLine,
                   subject = mark.subjectName,
                   marks = mark.marks,
               }).ToList();

foreach(var name in combined)
{
    Console.WriteLine(name.id);
    Console.WriteLine(name.fname);
    Console.WriteLine(name.lname);
    Console.WriteLine(name.address);
    Console.WriteLine(name.subject);
    Console.WriteLine(name.marks);
    Console.WriteLine("---------------------------");
}
*/

//test for left join

/*
var combined = (from per in people
                join address in addresses
                on per.id equals address.PersonId into stdAddress
                from studentAdress in stdAddress.DefaultIfEmpty()
                select new
                {
                    StudentName = per.fName,
                    StudentAdress = studentAdress != null ? studentAdress.addressLine : "NA"
                }).ToList();

foreach (var name in combined)
{
    Console.WriteLine(name.StudentName);
    Console.WriteLine(name.StudentAdress);
    Console.WriteLine("---------------------------");
}
*/

//test for elementAt

/*
var element = (from num in numbers
               where num < 10
              select num).FirstOrDefault( x=> x > 20);
Console.WriteLine(element);
*/

//test for first

/*
Console.Write("Username: ");
string Username = Console.ReadLine();
Console.Write("Password: ");
string Password = Console.ReadLine();

var login = (from user in userList
             select user).FirstOrDefault(x => x.userName == Username && x.password == Password);

if(login == null)
{
    Console.WriteLine("Invalid username or password");
}
else
{
    Console.WriteLine("Content loading");
}
*/

//test for single

/*
var ms = (from num in numbers
          select num).SingleOrDefault(x => x > 29);

Console.WriteLine(ms);
*/