using UnityEngine;

public class Workshop : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         //As01_SyntaxIf();
         //As02_StringComparisonExample();
        //As03_NumberComparisonExample();
         //As04_AndOrOperatorExample();
        //As05_GuessingNumberExample();
         //As06_GuessingNumberMoreOrLessExample();
        As07_VerifyIdentityExample();
    }

    public bool isSixOClock;
    public void As01_SyntaxIf()
    {
        if (isSixOClock) {
            Debug.Log("the door open" );
                
        }
        Debug.Log("knock knock!");
    }

    public string password;
    public void As02_StringComparisonExample()
    {
        if (password == "Moon")
        {
            Debug.Log("password is correct");
        }
        if (password != "Moon")
        {
            Debug.Log("password is incorrect");
        }
        }

    public int as03Number;
    public void As03_NumberComparisonExample()
    {
        if(as03Number > 10)
        {
            Debug.Log("my number >10");
        }
        if(as03Number >= 10)
        {
            Debug.Log("my number >=10");
        }
        if (as03Number < 10)
        {
            Debug.Log("my number <10");
        }
        if (as03Number <= 10)
        {
            Debug.Log("my number <=10");
        }
        if (as03Number == 10)
        {
            Debug.Log("my number ==10");
        }
        if (as03Number != 10)
        {
            Debug.Log("my number !=10");
        }

    }

    public int as04Number;
    public void As04_AndOrOperatorExample()
    {
        if(as04Number > 8 && as04Number < 12)
        {
            Debug.Log("my number 8 > < 12 ");
        }
        if(as04Number < 8 || as04Number > 12)
        {
            Debug.Log("my number 8 || 12");
        }
    }

    public int as05GuessingNumber;
    public int as05RandomNumber;
    public void As05_GuessingNumberExample()
    {
        if(as05GuessingNumber == as05RandomNumber)
        {
            Debug.Log("Congratulation");
        }
        else 
        {
            Debug.Log("try again");
        }

    }

    public int as06GuessingNumber;
    public int as06RandomNumber;
    public void As06_GuessingNumberMoreOrLessExample()
    {
        if(as06GuessingNumber < as06RandomNumber)
        {
            Debug.Log("too low");
        }
        else if (as06GuessingNumber < as06RandomNumber)
        {
            Debug.Log("Too High");
        }
        else
        {
            Debug.Log("CONGRATULATION");
        }

    }

    public string as07Username;
    public string as07Password;
    public int as07Age;
    public bool as07IsPaid;
    public void As07_VerifyIdentityExample()
    {
        if (as07Username == "user" && as07Password == "User123")
        {
            Debug.Log("you have acces");
            if(as07IsPaid)
            {
                Debug.Log("VIP Member");
            }
            else 
            {
                Debug.Log("Free Member"); 
            }
            if(as07Age >= 18)
            {
                Debug.Log("YOU HAV ACCESS TO EXCLUSIVE CONTENT");
            }
        }
        else
        {
            Debug.Log("you are guess");
        }
    }
}
