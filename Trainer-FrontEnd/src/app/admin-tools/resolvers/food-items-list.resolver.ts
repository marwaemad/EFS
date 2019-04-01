import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { ResultMessage } from '../../shared/models/result-message';
import { FoodItem } from 'src/app/shared/models/neutrints/food-item-dto';
import { NeutrintsService } from '../../shared/services/neutrints.service';
import { PagedResult } from 'src/app/shared/models/paged-result';
import { AppConfig } from 'src/config/app.config';
import { catchError, map } from 'rxjs/operators';
import { HttpErrorResponse } from '@angular/common/http';
import { ErrorHandlingService } from 'src/app/shared/services/error-handling.service';
@Injectable()
export class FoodItemsListResolver implements Resolve<Observable<ResultMessage<PagedResult<FoodItem>>>> {
    constructor(private service: NeutrintsService, private errorHandlingService: ErrorHandlingService) {
    }
    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<ResultMessage<PagedResult<FoodItem>>> {
        const pageSize = AppConfig.settings.pagination.neutrintsForAdmin.pageSize;
        return this.service.get('?pageNo=1&pageSize=' + pageSize).pipe(
            map((data: Observable<ResultMessage<PagedResult<FoodItem>>>) => data), catchError((error: HttpErrorResponse) => {
                this.errorHandlingService.handle(error);
                return throwError(error);
            })
        );
    }
}
