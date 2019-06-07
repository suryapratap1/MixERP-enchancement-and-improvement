DROP VIEW IF EXISTS core.salesperson_scrud_view;

CREATE VIEW core.salesperson_scrud_view
AS
SELECT
    core.salespersons.salesperson_id,
    core.sales_teams.sales_team_code || ' (' || core.sales_teams.sales_team_name || ')' AS sales_team,
    core.salespersons.salesperson_code,
    core.salespersons.salesperson_name,
    core.salespersons.address,
    core.salespersons.contact_number,
    core.salespersons.commission_rate,
    core.accounts.account_number || ' (' || core.accounts.account_name || ')' AS account,
    core.salespersons.photo
FROM
    core.salespersons
INNER JOIN core.sales_teams
ON core.salespersons.sales_team_id = core.sales_teams.sales_team_id
INNER JOIN core.accounts
ON core.salespersons.account_id = core.accounts.account_id;
