#Revising Aggregations - The Count Function
select count(*) from city where population > 100000;

#Revising Aggregations - The Sum Function
select sum(population) from city where district = 'California';

#Average Population
select round(population) from (select avg(population) as population from city)

#Japan Population
select sum(population) from city where countrycode = 'JPN';

#Population Density Difference
select max(population) - min(population) from city;

#Weather Observation Station 2
select concat(round(sum(lat_n), 2), ' ', round(sum(long_w), 2)) from station;