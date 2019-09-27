export const apiPaths = {
  medicao_valor: {
    getAll: 'MedicaoVazao',
    get: function(id) {
      return `MedicaoVazao/${id}`;
    }
  },
  medidor_vazao: {
    getAll: 'MedidorVazao',
    edit: function(id) {
      return `MedidorVazao/${id}`;
    },
    delete: function(id) {
      return `MacroPonto/${id}`;
    }
  }
};
