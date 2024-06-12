using System;
using Xunit;

namespace CesarCipher.Tests
{
    public class CipherTests
    {
        [Fact]
        public void Encrypt_ShouldReturnEncryptedText()
        {
            // Arrange
            string input = "Hello, World!";
            int shift = 3;
            string expected = "Khoor, Zruog!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Decrypt_ShouldReturnDecryptedText()
        {
            // Arrange
            string input = "Khoor, Zruog!";
            int shift = 3;
            string expected = "Hello, World!";

            // Act
            string result = Cipher.Decrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Encrypt_ShouldHandleNonAlphabeticCharacters()
        {
            // Arrange
            string input = "Hello, World 123!";
            int shift = 5;
            string expected = "Mjqqt, Btwqi 123!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Encrypt_ShouldHandleUppercaseLetters()
        {
            // Arrange
            string input = "HELLO, WORLD!";
            int shift = 7;
            string expected = "OLSSV, DVYSK!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Encrypt_ShouldHandleLowercaseLetters()
        {
            // Arrange
            string input = "hello, world!";
            int shift = 7;
            string expected = "olssv, dvysk!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Encrypt_ShouldHandleShiftWrapAround()
        {
            // Arrange
            string input = "xyz";
            int shift = 3;
            string expected = "abc";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Decrypt_ShouldHandleShiftWrapAround()
        {
            // Arrange
            string input = "abc";
            int shift = 3;
            string expected = "xyz";

            // Act
            string result = Cipher.Decrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
