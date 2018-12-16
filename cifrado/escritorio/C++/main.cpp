#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAX 128

void cifradoCesar(char frase[MAX],int numero);
void invertidoCifrado(char cadena[MAX], int tamano);
 
void cifradoCesar(char frase[MAX],int numero){
    int i=0;
    while(frase[i]!='\0'){
        frase[i]=frase[i]+numero;
        i++;
    }
    printf("\nLa frase encriptado es:\n%s\n",frase);
}

void invertidoCifrado(char cadena[MAX], int tamano)
{
    char invertido[tamano];

    for (int x=0, y=tamano-1; x<tamano; x++, y--){
        invertido[x]=cadena[y];
    }
    invertido[tamano] = '\0';
     printf("\nCifrado Invertido:\n%s\n",invertido);

}


int main(){    
    int x;
    char cadena[MAX];
    int longitud=sizeof(cadena);
    printf("CIFRADO CESAR:\n");
    printf("-----------------------------\n");
    printf("Introduzca una frase: ");
    scanf("%128[^\n]", cadena);
    while(getchar()!='\n');
    
    printf("Desplazamiento: ");
    scanf("%d",&x);
    while(getchar()!='\n');

    cifradoCesar(cadena, x);
    getchar();
    
    invertidoCifrado(cadena,longitud);
    getchar();
    
    return 0;
}
