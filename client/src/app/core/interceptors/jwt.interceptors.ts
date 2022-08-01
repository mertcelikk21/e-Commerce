import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable() /*dışarıda kullanabilmek için*/ 

export class JWTInterceptor implements HttpInterceptor{

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const token = localStorage.getItem('token');
        if(token){
            req=req.clone({
                setHeaders:{
                    Authorization:`Bearer ${token}`
                }
            });
        }
        return next.handle(req);
    }

}