SELECT P.Name, C.Name FROM Prouct AS P 
JOIN ProductCategory AS PC ON PC.ProductId = P.ProductId
JOIN Catgory AS C ON PC.CatgoryId = C.CategoryId