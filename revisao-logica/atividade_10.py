def main(): 
    try:
        count = 0

        while count < 3:
        
            print("Por favor informe os valores abaixo:")
            user_name = input('Login: ')
            user_password = input('Password: ')

            if (user_name == 'IFSP' and user_password == 'PosWEB'):
                print('Login efetuado com sucesso')
                return
            else:
                count += 1

            if (count == 3):
                print('Acesso Negado')
                return
    except:
        print(f'Não foi possivel efetuar login')

main()