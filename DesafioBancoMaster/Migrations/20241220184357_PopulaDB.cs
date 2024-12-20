using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioBancoMaster.Migrations
{
    /// <inheritdoc />
    public partial class PopulaDB : Migration
    {


        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','GRU','BRC',10)  ");
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','BRC','SCL',5)  ");
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','GRU','CDG',75)  ");
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','GRU','SCL',20)  ");
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','GRU','ORL',56)  ");
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','ORL','CDG',5)  ");
            mb.Sql(" Insert into Rotas(ID,Origem,Destino,Custo) VALUES('"+Guid.NewGuid() + "','SCL','ORL',20)  ");
        }
        https://www.youtube.com/watch?v=6YIRKBsRWVI
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }


    }
}
