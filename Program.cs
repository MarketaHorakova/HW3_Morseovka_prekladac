//Morseova abeceda
// 26 znaků bez ch
// indexy 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25
// pismen a, b, c, d, e, f, g, h, i, j,  k,  l,  m,  n,  o,  p,  q,  r,  s,  t,  u,  v,  w,  x,  y,  z

string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

Console.WriteLine("Co chceš přeložit do Morseovky (zatim bez ch)?");
string inputText = Console.ReadLine().ToLower();

char[] text = inputText.ToCharArray();
string[] znakyMorseTextBezJoin = new string[text.Length];
int i = 0;

foreach (char c in text)
{
    switch (c)
    {
        case 'a':
            znakyMorseTextBezJoin[i] = morseovyZnaky[0]; break;
        case 'b':
            znakyMorseTextBezJoin[i] = morseovyZnaky[1]; break;
        case 'c':
            znakyMorseTextBezJoin[i] = morseovyZnaky[2]; break;
        case 'd':
            znakyMorseTextBezJoin[i] = morseovyZnaky[3]; break;
        case 'e':
            znakyMorseTextBezJoin[i] = morseovyZnaky[4]; break;
        case 'f':
            znakyMorseTextBezJoin[i] = morseovyZnaky[5]; break;
        case 'g':
            znakyMorseTextBezJoin[i] = morseovyZnaky[6]; break;
        case 'h':
            znakyMorseTextBezJoin[i] = morseovyZnaky[7]; break;
        case 'i':
            znakyMorseTextBezJoin[i] = morseovyZnaky[8]; break;
        case 'j':
            znakyMorseTextBezJoin[i] = morseovyZnaky[9]; break;
        case 'k':
            znakyMorseTextBezJoin[i] = morseovyZnaky[10]; break;
        case 'l':
            znakyMorseTextBezJoin[i] = morseovyZnaky[11]; break;
        case 'm':
            znakyMorseTextBezJoin[i] = morseovyZnaky[12]; break;
        case 'n':
            znakyMorseTextBezJoin[i] = morseovyZnaky[13]; break;
        case 'o':
            znakyMorseTextBezJoin[i] = morseovyZnaky[14]; break;
        case 'p':
            znakyMorseTextBezJoin[i] = morseovyZnaky[15]; break;
        case 'q':
            znakyMorseTextBezJoin[i] = morseovyZnaky[16]; break;
        case 'r':
            znakyMorseTextBezJoin[i] = morseovyZnaky[17]; break;
        case 's':
            znakyMorseTextBezJoin[i] = morseovyZnaky[18]; break;
        case 't':
            znakyMorseTextBezJoin[i] = morseovyZnaky[19]; break;
        case 'u':
            znakyMorseTextBezJoin[i] = morseovyZnaky[20]; break;
        case 'v':
            znakyMorseTextBezJoin[i] = morseovyZnaky[21]; break;
        case 'w':
            znakyMorseTextBezJoin[i] = morseovyZnaky[22]; break;
        case 'x':
            znakyMorseTextBezJoin[i] = morseovyZnaky[23]; break;
        case 'y':
            znakyMorseTextBezJoin[i] = morseovyZnaky[24]; break;
        case 'z':
            znakyMorseTextBezJoin[i] = morseovyZnaky[25]; break;
        case ' ':
            znakyMorseTextBezJoin[i] = ""; break;
        case '.':
            znakyMorseTextBezJoin[i] = "/"; break;
        case ',':
            znakyMorseTextBezJoin[i] = "/"; break;
    }
    i++;
}

string prelozenyString = string.Join("/",znakyMorseTextBezJoin);
Console.WriteLine(prelozenyString);

Console.ReadLine();
