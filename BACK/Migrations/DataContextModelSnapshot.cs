﻿// <auto-generated />
using System;
using ApiTcc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiTcc.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiTcc.Models.Associado", b =>
                {
                    b.Property<int>("associadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Associado");

                    b.Property<byte[]>("associadoImagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("cnpjCadAssociado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailCadAssociado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoCadAssociado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeCadAssociado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senhaCadAssociado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telCadAssociado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("associadoId");

                    b.ToTable("Associados");

                    b.HasData(
                        new
                        {
                            associadoId = 1,
                            cnpjCadAssociado = "1231134",
                            emailCadAssociado = "associadoa@associadoa.com",
                            enderecoCadAssociado = "Rua do Associado A",
                            nomeCadAssociado = "Associado A",
                            senhaCadAssociado = "123456"
                        },
                        new
                        {
                            associadoId = 2,
                            cnpjCadAssociado = "1231134",
                            emailCadAssociado = "associadob@associadob.com",
                            enderecoCadAssociado = "Rua do Associado B",
                            nomeCadAssociado = "Associado B",
                            senhaCadAssociado = "123456"
                        },
                        new
                        {
                            associadoId = 3,
                            cnpjCadAssociado = "1231134",
                            emailCadAssociado = "associadoc@associadoc.com",
                            enderecoCadAssociado = "Rua do Associado C",
                            nomeCadAssociado = "Associado C",
                            senhaCadAssociado = "123456"
                        },
                        new
                        {
                            associadoId = 4,
                            cnpjCadAssociado = "1231134",
                            emailCadAssociado = "associadod@associadod.com",
                            enderecoCadAssociado = "Rua do Associado D",
                            nomeCadAssociado = "Associado D",
                            senhaCadAssociado = "123456"
                        },
                        new
                        {
                            associadoId = 5,
                            cnpjCadAssociado = "1231134",
                            emailCadAssociado = "associadoe@associadoe.com",
                            enderecoCadAssociado = "Rua do Associado E",
                            nomeCadAssociado = "Associado E",
                            senhaCadAssociado = "123456"
                        });
                });

            modelBuilder.Entity("ApiTcc.Models.Cliente", b =>
                {
                    b.Property<int>("clienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Cliente");

                    b.Property<byte[]>("clienteImagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("cpfCadCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailCadCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enderecoCadCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeCadCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senhaCadCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telCadCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("clienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            clienteId = 1,
                            cpfCadCliente = "12345678998",
                            emailCadCliente = "email@email.com",
                            enderecoCadCliente = "Rua do Cliente A",
                            nomeCadCliente = "Cliente A",
                            senhaCadCliente = "123456",
                            telCadCliente = "11900000000"
                        },
                        new
                        {
                            clienteId = 2,
                            cpfCadCliente = "12345678998",
                            emailCadCliente = "email@email.com",
                            enderecoCadCliente = "Rua do Cliente B",
                            nomeCadCliente = "Cliente B",
                            senhaCadCliente = "123456",
                            telCadCliente = "11900000000"
                        },
                        new
                        {
                            clienteId = 3,
                            cpfCadCliente = "12345678998",
                            emailCadCliente = "email@email.com",
                            enderecoCadCliente = "Rua do Cliente C",
                            nomeCadCliente = "Cliente C",
                            senhaCadCliente = "123456",
                            telCadCliente = "11900000000"
                        },
                        new
                        {
                            clienteId = 4,
                            cpfCadCliente = "12345678998",
                            emailCadCliente = "email@email.com",
                            enderecoCadCliente = "Rua do Cliente D",
                            nomeCadCliente = "Cliente D",
                            senhaCadCliente = "123456",
                            telCadCliente = "11900000000"
                        },
                        new
                        {
                            clienteId = 5,
                            cpfCadCliente = "12345678998",
                            emailCadCliente = "email@email.com",
                            enderecoCadCliente = "Rua do Cliente E",
                            nomeCadCliente = "Cliente E",
                            senhaCadCliente = "123456",
                            telCadCliente = "11900000000"
                        });
                });

            modelBuilder.Entity("ApiTcc.Models.ComissaoAssociado", b =>
                {
                    b.Property<int>("associadoId")
                        .HasColumnType("int");

                    b.Property<double>("porcentagemComissao")
                        .HasColumnType("float");

                    b.Property<double>("valorFixo")
                        .HasColumnType("float");

                    b.ToTable("ComissoesAssociados");
                });

            modelBuilder.Entity("ApiTcc.Models.ItemPedido", b =>
                {
                    b.Property<int>("itemPedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("associadoId")
                        .HasColumnType("int");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("codigoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("precoProduto")
                        .HasColumnType("real");

                    b.Property<int>("produtoId")
                        .HasColumnType("int");

                    b.Property<int>("qtdProduto")
                        .HasColumnType("int");

                    b.HasKey("itemPedidoId");

                    b.HasIndex("clienteId");

                    b.HasIndex("produtoId");

                    b.ToTable("ItensPedido");

                    b.HasData(
                        new
                        {
                            itemPedidoId = 1,
                            associadoId = 0,
                            clienteId = 1,
                            precoProduto = 10f,
                            produtoId = 1,
                            qtdProduto = 10
                        },
                        new
                        {
                            itemPedidoId = 2,
                            associadoId = 0,
                            clienteId = 1,
                            precoProduto = 10f,
                            produtoId = 1,
                            qtdProduto = 10
                        },
                        new
                        {
                            itemPedidoId = 3,
                            associadoId = 0,
                            clienteId = 1,
                            precoProduto = 10f,
                            produtoId = 1,
                            qtdProduto = 10
                        });
                });

            modelBuilder.Entity("ApiTcc.Models.Pedido", b =>
                {
                    b.Property<int>("pedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StatusPedido")
                        .HasColumnType("int");

                    b.Property<int>("associadoId")
                        .HasColumnType("int");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("codigoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dataPedido")
                        .HasColumnType("datetime2");

                    b.Property<int?>("itemPedidoId")
                        .HasColumnType("int");

                    b.Property<int>("produtoId")
                        .HasColumnType("int");

                    b.Property<float>("valortotalPedido")
                        .HasColumnType("real");

                    b.HasKey("pedidoId");

                    b.HasIndex("clienteId");

                    b.HasIndex("itemPedidoId");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            pedidoId = 1,
                            StatusPedido = 0,
                            associadoId = 0,
                            clienteId = 1,
                            produtoId = 0,
                            valortotalPedido = 0f
                        },
                        new
                        {
                            pedidoId = 2,
                            StatusPedido = 0,
                            associadoId = 0,
                            clienteId = 2,
                            produtoId = 0,
                            valortotalPedido = 0f
                        },
                        new
                        {
                            pedidoId = 3,
                            StatusPedido = 0,
                            associadoId = 0,
                            clienteId = 3,
                            produtoId = 0,
                            valortotalPedido = 0f
                        });
                });

            modelBuilder.Entity("ApiTcc.Models.Produto", b =>
                {
                    b.Property<int>("produtoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("associadoId")
                        .HasColumnType("int");

                    b.Property<string>("codigoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricaoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fabricanteProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precoProduto")
                        .HasColumnType("int");

                    b.Property<byte[]>("produtoImagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("qtdProduto")
                        .HasColumnType("int");

                    b.HasKey("produtoId");

                    b.HasIndex("associadoId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            produtoId = 1,
                            associadoId = 1,
                            codigoProduto = "10001310000310",
                            fabricanteProduto = "Fabricante A",
                            nomeProduto = "Ração Golden Fórmula Mini Bits Para Cães Adultos Pequeno Porte Sabor Carne e Arroz",
                            precoProduto = 20,
                            qtdProduto = 5
                        },
                        new
                        {
                            produtoId = 2,
                            associadoId = 2,
                            codigoProduto = "10001320000030",
                            fabricanteProduto = "Fabricante B",
                            nomeProduto = "Ração Seca PremieR Pet Golden Mega Cães Filhotes Raças Grandes Frango e Arroz",
                            precoProduto = 150,
                            qtdProduto = 1
                        },
                        new
                        {
                            produtoId = 3,
                            associadoId = 3,
                            codigoProduto = "3108200-1",
                            fabricanteProduto = "Fabricante B",
                            nomeProduto = "Ração Premier Golden Formula Cães Filhotes Carne e Arroz",
                            precoProduto = 146,
                            qtdProduto = 1
                        });
                });

            modelBuilder.Entity("ApiTcc.Models.Sac", b =>
                {
                    b.Property<int>("sacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descSac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailSac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeSac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("problemaSac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefoneSac")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sacId");

                    b.ToTable("Sac");
                });

            modelBuilder.Entity("BACK.Models.ComissoesRegistro", b =>
                {
                    b.Property<int>("comissoesregistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("A")
                        .HasColumnType("real");

                    b.Property<float>("BXC")
                        .HasColumnType("real");

                    b.Property<int>("associadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dataComissao")
                        .HasColumnType("datetime2");

                    b.Property<int>("pedidoId")
                        .HasColumnType("int");

                    b.Property<string>("statusComissao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("comissoesregistroId");

                    b.ToTable("ComissoesRegistros");
                });

            modelBuilder.Entity("ApiTcc.Models.ItemPedido", b =>
                {
                    b.HasOne("ApiTcc.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTcc.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("produtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("ApiTcc.Models.Pedido", b =>
                {
                    b.HasOne("ApiTcc.Models.Cliente", "Cliente")
                        .WithMany("Pedido")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTcc.Models.ItemPedido", "ItemPedido")
                        .WithMany()
                        .HasForeignKey("itemPedidoId");

                    b.Navigation("Cliente");

                    b.Navigation("ItemPedido");
                });

            modelBuilder.Entity("ApiTcc.Models.Produto", b =>
                {
                    b.HasOne("ApiTcc.Models.Associado", "Associado")
                        .WithMany("Produtos")
                        .HasForeignKey("associadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Associado");
                });

            modelBuilder.Entity("ApiTcc.Models.Associado", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ApiTcc.Models.Cliente", b =>
                {
                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
