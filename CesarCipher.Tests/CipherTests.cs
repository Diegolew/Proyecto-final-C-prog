using Xunit;
using CesarCipher;

public class CipherTests
{
    [Fact]
    public void Encrypt_ShouldHandleAlphabet_UpperCase()
    {
        // Arrange
        string plaintext = "HELLO";
        int shift = 3;
        string expected = "KHOOR";

        // Act
        string encryptedText = Cipher.Encrypt(plaintext, shift);

        // Assert
        Assert.Equal(expected, encryptedText);
    }

    [Fact]
    public void Encrypt_ShouldHandleAlphabet_LowerCase()
    {
        // Arrange
        string plaintext = "hello";
        int shift = 5;
        string expected = "mjqqt";

        // Act
        string encryptedText = Cipher.Encrypt(plaintext, shift);

        // Assert
        Assert.Equal(expected, encryptedText);
    }

    [Fact]
    public void Encrypt_ShouldHandleDigits()
    {
        // Arrange
        string plaintext = "12345";
        int shift = 1;
        string expected = "23456";

        // Act
        string encryptedText = Cipher.Encrypt(plaintext, shift);

        // Assert
        Assert.Equal(expected, encryptedText);
    }

    [Fact]
    public void Decrypt_ShouldHandleAlphabet_UpperCase()
    {
        // Arrange
        string ciphertext = "KHOOR";
        int shift = 3;
        string expected = "HELLO";

        // Act
        string decryptedText = Cipher.Decrypt(ciphertext, shift);

        // Assert
        Assert.Equal(expected, decryptedText);
    }

    [Fact]
    public void Decrypt_ShouldHandleDigits()
    {
        // Arrange
        string ciphertext = "23456";
        int shift = 1;
        string expected = "12345";

        // Act
        string decryptedText = Cipher.Decrypt(ciphertext, shift);

        // Assert
        Assert.Equal(expected, decryptedText);
    }
}
