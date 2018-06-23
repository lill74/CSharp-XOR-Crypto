## CSharp XOR Crypto
**XOR Encryption Example**

*Functions*

|Type|Name|Args|Function|
|--|--|--|--|
|byte[]|Reversebytes()|bytes[] a|Reverse byte array for decrypt|
|byte[]|Encrypt()|bytes[] a, string key|Encrypt byte array using XOR bitwise operation|
|string|Decrypt()|byte[] a, string key|Decrypt byte array through reverse encryption|
 
*Example*

    Cipher Enc = new Cipher();
    string data = "I LOVE Cryptographics";
    byte[] bytes = Encoding.UTF8.GetBytes(data);
    byte[] bts = Enc.Encrypt(bytes, "pass");
    Enc.Decrypt(bts, "pass");
    
result : I LOVE Cryptographics

*Contacts*

> Email: a0103932@naver.com
