CREATE TABLE bes_banks (
id                  INTEGER         
						IDENTITY(1,1)
                        CONSTRAINT pk_bes_banks_id
                        PRIMARY KEY
                        CONSTRAINT ck_bes_banks_id
                        CHECK (id > 0),
description			VARCHAR(40)		NOT NULL,
status				NUMERIC(1)      
						CONSTRAINT bit_bes_banks_status
                        CHECK (status IN (0,1))
)
GO