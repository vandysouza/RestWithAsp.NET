FROM mcr.microsoft.com/mssql/server:2017-latest

# Configurações para executar como não-root
USER root

# Adicione aqui qualquer configuração adicional que seja necessária

# Criar usuário mssql
RUN useradd -ms /bin/bash mssql

# Alterar para o usuário mssql (não-root)
USER mssql

