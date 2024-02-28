import random

def main(): 
    try:
        random_value = random.randint(0, 9)
        correct = False
        count = 1

        while correct == False :
            print("Por favor informe um numero inteiro abaixo:")
            value = int(input('Numero: '))

            if (value == random_value):
                correct = True
            else: 
                count += 1

        print(f'Voce acertou o numero {random_value} em {count} tentativas')
    except:
        print('Não foi possivel participar do jogo de adivinhação')

main()