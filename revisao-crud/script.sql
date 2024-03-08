CREATE DATABASE RevisaoCrud;

USE RevisaoCrud;

CREATE TABLE Funcionario (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Matricula INT,
    Salario FLOAT,
    DataAdmissao DATE,
    Nome VARCHAR(110),
    CPF VARCHAR(14),
    Sexo VARCHAR(1),
    CEP VARCHAR(9),
    Endereco VARCHAR(140),
    Telefone VARCHAR(16),
    DataNascimento DATE,
    IsDeleted BOOLEAN
);

CREATE TABLE Dependente (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Matricula INT,
    Salario FLOAT,
    DataAdimissao DATE,
    Nome VARCHAR(110),
    CPF VARCHAR(14),
    Sexo VARCHAR(1),
    CEP VARCHAR(9),
    Endereco VARCHAR(140),
    Telefone VARCHAR(16),
    DataNascimento DATE,
    IsDeleted BOOLEAN,
    IdFuncionario INT,
    FOREIGN KEY (IdFuncionario ) REFERENCES Funcionario (Id)
);

CREATE TABLE Cargo (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(110),
    Descricao VARCHAR(240),
    DataInicio DATE,
    DataFim DATE,
    IsDeleted BOOLEAN
    IdFuncionario INT,
    FOREIGN KEY (IdFuncionario ) REFERENCES Funcionario (Id)
);