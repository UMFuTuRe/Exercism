using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneNumberSplit = phoneNumber.Split('-');
        string dialCode = phoneNumberSplit[0];
        string fakeNumber = phoneNumberSplit[1];
        string lastDigits = phoneNumberSplit[2];

        return (dialCode.Equals("212"), fakeNumber.Equals("555"), lastDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.Item2;
    }
}
