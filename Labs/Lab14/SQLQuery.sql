SELECT Car_Brand FROM CarTest WHERE Year IN (2015, 2017) GROUP BY Car_Brand HAVING COUNT(*) > 1 ORDER BY Car_Brand;

SELECT Year, Car_Number From CarTest WHERE Car_Brand in ('Toyota', 'Kia')

SELECT Car_Brand FROM CarTest WHERE Year BETWEEN 2015 and 2020

SELECT Car_Brand, Car_Model FROM CarTest WHERE Year BETWEEN 2020 and 2023

SELECT Car_Brand FROM CarTest WHERE Car_Number LIKE '12%'

SELECT Car_Brand FROM CarTest WHERE Car_Brand LIKE 'C%'

SELECT DISTINCT Car_Number FROM CarTest

SELECT Car_Brand FROM CarTest ORDER BY Car_Brand

SELECT Car_Brand FROM CarTest ORDER BY Car_Brand DESC
