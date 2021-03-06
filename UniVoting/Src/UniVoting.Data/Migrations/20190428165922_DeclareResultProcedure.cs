﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace UniVoting.Data.Migrations
{
    public partial class DeclareResultProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE [dbo].[DeclareResult]
                AS 
                SELECT  vw_CandidateVotes.Name, c.CandidatePicture, vw_CandidateVotes.Position,
                  vw_CandidateVotes.Vote, vw_CandidateVotes.Percentage AS 'Percentage Votes',
                  vw_CandidateVotes.Skipped AS 'Skipped',vw_CandidateVotes.[Skipped Percentage] AS 'PercentageSkipped'
                FROM vw_CandidateVotes INNER JOIN
                   Candidates AS c ON vw_CandidateVotes.ID = c.ID
                ORDER BY c.PositionID
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE [DeclareResult]");
        }
    }
}
