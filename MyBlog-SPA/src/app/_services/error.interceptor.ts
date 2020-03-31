import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpErrorResponse, HTTP_INTERCEPTORS } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  intercept(
    req: import('@angular/common/http').HttpRequest<any>,
    next: import('@angular/common/http').HttpHandler
  ): import('rxjs').Observable<import('@angular/common/http').HttpEvent<any>> {
    return next.handle(req).pipe(
        catchError(error => {
            if (error.status === 401) {
                    return throwError(error.statusText);
            }
            if (error instanceof HttpErrorResponse) {
                const applicationError = error.headers.get('Application-Error');
                if (applicationError) {
                    throw throwError(applicationError);
                }
                const serverError =  error.error.errors || error.error;
                let modelStateErrors = '';
                if (serverError.error && typeof serverError.error === 'object') {
                    console.log('1 - this handler is triggered');
                    for (const key in serverError.error) {
                        if (serverError.error[key]) {
                            modelStateErrors += serverError.errors[key] + '\n';
                        }
                    }
                } else if (serverError && typeof serverError === 'object') {
                    console.log('2 - this handler is triggered');
                    for (const key in serverError) {
                      if (serverError[key]) {
                        modelStateErrors += serverError[key] + '\n';
                      }
                    }
                }
                return throwError(modelStateErrors || serverError || 'Server Error');
            }
        })
    );
  }
}

export const ErrorInterceptorProvider = {
        provide: HTTP_INTERCEPTORS,
        useClass: ErrorInterceptor,
        multi: true
};
