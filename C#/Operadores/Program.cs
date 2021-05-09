using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores são utilizados para realizar operações em variáveis e valores.
            // Exemplo 
            int x = 100 + 250;
            Console.WriteLine(x);

            // Exemplo2
            int soma1 = 100 + 200; // 300 (100 + 200)
            int soma2 = soma1 + 250; // 550 (300 + 250)
            int soma3 = soma2 + soma2; // 1100 (550 + 550)

            /* 
            Operador	Nome	        Descrição                   Exemplo
                + 	    Adição	        faz uma adição	             x + y	
                -	    Subtração	    faz uma subtração       	x - y	
                *	    Multiplicação	Multiplica 2 valores	    x * y	
                /	    Division	    faz uma divisão             x / y	
                %	    Modulo	        retorna o modulo divisão    x % y	
                ++	    incremento	    add um valor a x x+1	    x++	
                --	    redução         reduz um valor de x x-1     x--
            */
        
            // Operadores de atribuição C#
            int x1 = 10;
            x1 += 5;
            /* 
            Uma lista de todos os operadores de atribuição:

Operator	Example	            Same As	
=	        x = 5	            x = 5	
+=	        x += 3	            x = x + 3	
-=	        x -= 3	            x = x - 3	
*=	        x *= 3	            x = x * 3	
/=	        x /= 3	            x = x / 3	
%=	        x %= 3	            x = x % 3	
&=	        x &= 3	            x = x & 3	
|=	        x |= 3            	x = x | 3	
^=	        x ^= 3          	x = x ^ 3	
>>=	        x >>= 3	            x = x >> 3	
<<=	        x <<= 3         	x = x << 3	
Operadores de comparação c#
Os operadores de comparação são usados para comparar dois valores:

Operator	Name	Example	Try it
==	Equal to	x == y	
!=	Not equal	x != y	
>	Greater than	x > y	
<	Less than	x < y	
>=	Greater than or equal to	x >= y	
<=	Less than or equal to	x <= y	
C# Operadores Lógicos
Operadores lógicos são usados para determinar a lógica entre variáveis ou valores:

Operator	Name	Description	Example	Try it
&& 	Logical and	Returns true if both statements are true	x < 5 &&  x < 10	
|| 	Logical or	Returns true if one of the statements is true	x < 5 || x < 4	
!	Logical not	Reverse the result, returns false if the result is true	!(x < 5 && x < 10)
*/
        }
    }
}
