using System;
using PetaPoco;

namespace MixERP.Net.Entities.Public.Meta
{
    [TableName("public.sales_quotation_validation")]
    [PrimaryKey("validation_id", autoIncrement = false)]
    [ExplicitColumns]
    public class SalesQuotationValidation : PetaPocoDB.Record<SalesQuotationValidation>, IPoco
    {
        [Column("validation_id")]
        public string ValidationId { get; set; }

        [Column("tran_id")]
        public long TranId { get; set; }

        [Column("catalog")]
        public string Catalog { get; set; }

        [Column("valid_till")]
        public DateTime ValidTill { get; set; }

        [Column("added_on")]
        public DateTime AddedOn { get; set; }

        [Column("accepted")]
        public bool Accepted { get; set; }

        [Column("accepted_on")]
        public DateTime? AcceptedOn { get; set; }

        public static void CreateTable()
        {
            const string sql = @"DO
                                $$
                                BEGIN
                                    IF NOT EXISTS (
                                        SELECT 1 
                                        FROM   pg_catalog.pg_class c
                                        JOIN   pg_catalog.pg_namespace n ON n.oid = c.relnamespace
                                        WHERE  n.nspname = 'public'
                                        AND    c.relname = 'sales_quotation_validation'
                                        AND    c.relkind = 'r'
                                    ) THEN
                                        CREATE TABLE public.sales_quotation_validation
                                        (
                                            validation_id           text NOT NULL PRIMARY KEY,
                                            tran_id                 bigint NOT NULL,
                                            catalog                 text NOT NULL,
                                            added_on                TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT(NOW()),
                                            valid_till              TIMESTAMP WITH TIME ZONE NOT NULL,
                                            accepted                boolean NOT NULL DEFAULT(false),
                                            accepted_on             TIMESTAMP WITH TIME ZONE,
                                                                    CONSTRAINT sales_quotation_validation_unq
                                                                    UNIQUE(tran_id, catalog)
                                        );
                                    END IF;
                                END
                                $$
                                LANGUAGE plpgsql;
                                ";

            Factory.NonQuery(Factory.MetaDatabase, sql);
        }
    }
}